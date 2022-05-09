using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TestDelegate
    {
        public delegate void WriteMessage(string message);

        //generic delegate
        public delegate T add<T>(T param1, T param2);

        public static void DisplayMessage(string message)
        {
            Console.WriteLine($"Hello {message}");
        }

        public static void WriteToFile(string message)
        {
            try
            {
                StreamWriter sw = new StreamWriter("text.txt");
                sw.WriteLine(message + "is written to the file");
                sw.Flush();
                sw.Close();
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }

        static void Main(string[] args)
        {
            WriteMessage w = new WriteMessage(DisplayMessage);
            //w.Invoke("How are you doing");
            //w("Hello Nirmal");
            w += WriteToFile; //multicast delegate 
           
            w += (string message) => Console.WriteLine(message);
            w += (string name) => { string greeting = $"Hello {name}"; Console.WriteLine(greeting); };
            w.Invoke("Delegates and events");

            //generic deletage

            add<int> sum = Sum;
            Console.WriteLine(sum(10,20));

            ProcessBusinessLogic process = new ProcessBusinessLogic();
            process.ProcessCompleted += Process_ProcessCompleted;
            process.StartProcess();

            Calculation calculation = new Calculation();
            calculation.PerformAddition += Calculation_PerformAddition;
            calculation.PerformAddition += Calculation_PerformAddition1;
            calculation.PublishEvent();

            EmployeeDetails employeeDetails = new EmployeeDetails();
            employeeDetails.EmployeeDetail += EmployeeDetails_EmployeeDetail;
            employeeDetails.PublishEvent();
            Console.Read();
        }

        private static void EmployeeDetails_EmployeeDetail(object sender, EmployeeEventArgs e)
        {
            Console.WriteLine($"Student Name : {e.Name}, RollNo : {e.Rollno}");
        }

        private static void Calculation_PerformAddition1(object sender, CalculationEventAgrs e)
        {
            Console.WriteLine($"Subtraction : {e.Num1 - e.Num2}");
        }

        private static void Calculation_PerformAddition(object sender, CalculationEventAgrs e)
        {
            Console.WriteLine($"Addition : {e.Num1 + e.Num2}");
        }

        private static void Process_ProcessCompleted()
        {
            Console.WriteLine("Process Completed");
        }

        private static int Sum(int param1, int param2)
        {
            return param1 + param2;
        }
    }

    class ProcessBusinessLogic
    {
        public delegate void Notify();
        public event Notify ProcessCompleted;
        public void StartProcess()
        {
            Console.WriteLine("Process Started");

            OnProcessCompleted();
        }

        private void OnProcessCompleted()
        {
            ProcessCompleted?.Invoke();
        }
    }

    class Calculation
    {
        public event EventHandler<CalculationEventAgrs> PerformAddition;

        public void PublishEvent()
        {
            CalculationEventAgrs args = new CalculationEventAgrs { Num1 = 40, Num2 = 50 };
            SendData(args);
        }

        protected virtual void SendData(CalculationEventAgrs args)
        {
            PerformAddition?.Invoke(this, args);
        }
    }

    class EmployeeDetails
    {
        public event EventHandler<EmployeeEventArgs> EmployeeDetail;

        public void PublishEvent()
        {
            EmployeeEventArgs args = new EmployeeEventArgs { Name = "Nirmal", Rollno = 179 };
            SendData(args);
        }

        protected virtual void SendData(EmployeeEventArgs args)
        {
            EmployeeDetail?.Invoke(this, args);
        }
    }

    class CalculationEventAgrs : EventArgs
    {
        private int num1;
        private int num2;

        public int Num1 { get => num1; set => num1 = value; }
        public int Num2 { get => num2; set => num2 = value; }
    }

    class EmployeeEventArgs : EventArgs
    {
        private string name;
        private int rollno;

        public string Name { get => name; set => name = value; }
        public int Rollno { get => rollno; set => rollno = value; }
    }
}

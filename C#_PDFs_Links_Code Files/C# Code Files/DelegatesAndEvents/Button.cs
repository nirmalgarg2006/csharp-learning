using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicConsoleApp.DelegatesAndEvents
{
    class Button
    {
        public delegate void ButtonHandler();
        public event ButtonHandler Click;

        public delegate void EventHandler(string name);        
        public event EventHandler logEvent;


        public void RaiseLogEvent()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            logEvent(name);            
        }

        public void RaiseClickEvent()
        {
            Click();
        }
        static void Main(string[] args)
        {
            Button btnClick = new Button();
            //btnClick.Click += BtnClick_Click;

            btnClick.Click += delegate ()
            {
                System.Threading.Thread.Sleep(3000);                  
                MessageBox.Show("Hello user. Enter your details");
            };

            btnClick.RaiseClickEvent();

            btnClick.logEvent += BtnClick_logEvent;
            btnClick.RaiseLogEvent();
            Console.Read();
        }

        private static void BtnClick_logEvent(string name)
        {
            Console.WriteLine(name+", you logged in at "+DateTime.Now.ToLongTimeString());
        }

        /*private static void BtnClick_Click()
        {
            System.Threading.Thread.Sleep(5000);
            //Console.WriteLine("Button is clicked");
            MessageBox.Show("Button is clicked");
        }*/
    }
}

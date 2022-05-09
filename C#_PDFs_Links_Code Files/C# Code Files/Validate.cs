using System;

namespace ValidateCreditCard
{
    public class Validate
    {
        string creditcardnumber;

        public string Creditcardnumber 
        { get => creditcardnumber; 
          set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Credit card number cannot be null");
                }
                else
                    creditcardnumber = value;
            }
        }

        public string validatecard()
        {
            string mesg=null;
            try
            {
                mesg = "Invalid Credit Card";

                char[] number = creditcardnumber.ToCharArray();

                if (number.Length == 16)
                {
                    mesg = "Valid Credit Card";
                }
            }
            catch(Exception e)
            {

            }

            return mesg;
        }
    }
}

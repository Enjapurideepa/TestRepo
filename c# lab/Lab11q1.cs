using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Lab11Q1 : CreditCardInfo
    {
        static void Main()
        {
            CreditClass creditclass = new CreditClass();
            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber();
            publisher.myevent += subscriber.Task;
            CreditCardInfo creditcardinfo = new CreditCardInfo();

            Console.WriteLine("Enter Credit Card Number:");
            creditclass.CreditCardNo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Credit Card Name:");
            creditclass.CreditCardName = Console.ReadLine();
            Console.WriteLine("ENter amount:");
            double amount = Convert.ToDouble(Console.ReadLine());
            if (creditcardinfo.MakePayment(amount))
            {
                publisher.FireEvent();
            }
            Console.WriteLine("BalanceAmount:" + creditcardinfo.BalanceAmount);



            Console.ReadLine();
        }
    }
}

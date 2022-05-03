using System;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Clock with Singleton
            ClockSingleton c1 = ClockSingleton.GetInatanse();
            ClockSingleton c2 = ClockSingleton.GetInatanse();

            Console.WriteLine(c1.time);
            Thread.Sleep(1000);
            Console.WriteLine(c2.time);

            if (c1 == c2)
                Console.WriteLine("Singelton works good");
            else
            {
                Console.WriteLine("Something went wrong in the creation of the Singelton");
            }
            #endregion


            #region Chain of responsibility

            BillHandler200 bill200 = new BillHandler200();
            BillHandler100 bill100 = new BillHandler100();
            BillHandler50 bill50 = new BillHandler50();
            BillHandler20 bill20 = new BillHandler20();

            bill200.SetNext(bill100);
            bill100.SetNext(bill50);
            bill50.SetNext(bill20);
            bill20.SetNext(null);

            Console.WriteLine("For request of 770:");
            bill200.HandlerRequest(770);
            Console.WriteLine("For request of 100:");
            bill200.HandlerRequest(100);
            Console.WriteLine("For request of 210:");
            bill200.HandlerRequest(210);
            #endregion
        }
    }
}

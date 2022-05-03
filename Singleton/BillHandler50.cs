using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class BillHandler50 : BillHandler
    {
        public override void HandlerRequest(int amount)
        {
            if(amount >= 50)
                Console.WriteLine("Giving 50 x:" + amount / 50);
            if (amount % 50 > 0)
                next.HandlerRequest(amount % 50);
        }
    }
}

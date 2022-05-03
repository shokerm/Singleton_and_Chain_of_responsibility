using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class BillHandler100 : BillHandler
    {
        public override void HandlerRequest(int amount)
        {
            if(amount >= 100)
                Console.WriteLine("Giving 100 x:" + amount / 100);
            if (amount % 100 > 0)
                next.HandlerRequest(amount % 100);

        }
    }
}

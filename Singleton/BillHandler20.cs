using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class BillHandler20 : BillHandler
    {
        public override void HandlerRequest(int amount)
        {
            if(amount >= 20)
                Console.WriteLine("Giving 20 x:" + amount / 20);
            if(amount % 20 > 0)
                Console.WriteLine("You can not ask less than 20...");

        }
    }
}

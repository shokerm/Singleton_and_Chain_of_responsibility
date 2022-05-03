using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    abstract class BillHandler
    {

        public BillHandler next;
        public BillHandler()
        {

        }

        public void SetNext(BillHandler billHandler)
        {
            next = billHandler;
        }

        public abstract void HandlerRequest(int amount);
    }
}

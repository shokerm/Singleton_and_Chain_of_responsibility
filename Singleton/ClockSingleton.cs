using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class ClockSingleton
    {
        private static ClockSingleton instanse;
        public DateTime time;
        private static readonly object key = new object();

        private ClockSingleton()
        {
            time = DateTime.Now;
        }

        public static ClockSingleton GetInatanse()
        {
            if (instanse == null)
            {
                lock (key)
                {
                    if (instanse == null)
                    {
                        instanse = new ClockSingleton();
                                        
                    }
                }
            }
            return instanse;
        }

        public  DateTime GetTime()
        {
            return time;
        }
    }
}

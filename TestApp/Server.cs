using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestApp
{
    static internal class Server
    {
        private static int count = 0;
        private static ManualResetEvent manualResetEvent = new ManualResetEvent(false);
        private static object lockObj = new object();
        public static int GetCount()
        {
            manualResetEvent.WaitOne();
            return count;  
        }

        public static void AddToCount(int value)
        {
            lock (lockObj)
            {
                manualResetEvent.Reset();
                count += value;
                manualResetEvent.Set();
            }
        }
    }
}

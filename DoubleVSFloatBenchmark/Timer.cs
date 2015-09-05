using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleVSFloatBenchmark
{
    static class Timer
    {
        public static TimeSpan Run(Action action)
        {
            var start = DateTime.Now;
            action.Invoke();
            return  DateTime.Now - start;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleVSFloatBenchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            new Benchmark(10000000).Excute();
        }
    }
}

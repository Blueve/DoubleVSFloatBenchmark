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
            new Benchmark(100 * 100 * 100 * 100).Excute();
            Console.ReadKey();
        }
    }
}

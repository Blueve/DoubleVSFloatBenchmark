using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleVSFloatBenchmark
{
    class Benchmark
    {
        private const float ZERO_F = 0f;
        private const float ONE_F = 1f;

        private const double ZERO_D = .0;
        private const double ONE_D = 1.0;

        private int _times;
        private Dictionary<string, long> _scoreF = CreateScoreDict();
        private Dictionary<string, long> _scoreD = CreateScoreDict();

        public IReadOnlyDictionary<string, long> ScoreF
        {
            get { return _scoreF; }
        }
        public IReadOnlyDictionary<string, long> ScoreD
        {
            get { return _scoreD; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="times">Must be multiple of 10</param>
        public Benchmark(int times)
        {
            _times = times / 10;
        }

        public void Excute()
        {
            Run(.1234f, 1.234f);
            Run(.1234, 1.234);
            Console.WriteLine($"{"", -5}{"float", 10}{"double", 10}");
            foreach(var item in _scoreF)
            {
                var p = _scoreF[item.Key] / (double)_scoreD[item.Key] - 1.0;
                Console.WriteLine($"{item.Key, -5}{_scoreF[item.Key], 10}{_scoreD[item.Key], 10}{p, 10:P}");
            }
        }

        private void Run(float x, float y)
        {
            // Test Add
            var tmp = ZERO_F;
            _scoreF["Add"] = Timer.Run(() =>
            {
                for (int i = 0; i < _times; i++)
                {
                    tmp += x; tmp += y;
                    tmp += x; tmp += y;
                    tmp += x; tmp += y;
                    tmp += x; tmp += y;
                    tmp += x; tmp += y;
                }
            }).Ticks;
            // Test Subtract
            tmp = ZERO_F;
            _scoreF["Sub"] = Timer.Run(() =>
            {
                for (int i = 0; i < _times; i++)
                {
                    tmp -= x; tmp -= y;
                    tmp -= x; tmp -= y;
                    tmp -= x; tmp -= y;
                    tmp -= x; tmp -= y;
                    tmp -= x; tmp -= y;
                }
            }).Ticks;
            // Test Multply
            tmp = ONE_F;
            _scoreF["Mul"] = Timer.Run(() =>
            {
                for (int i = 0; i < _times; i++)
                {
                    tmp *= x; tmp *= y;
                    tmp *= x; tmp *= y;
                    tmp *= x; tmp *= y;
                    tmp *= x; tmp *= y;
                    tmp *= x; tmp *= y;
                }
            }).Ticks;
            // Test Divide
            tmp = ONE_F;
            _scoreF["Div"] = Timer.Run(() =>
            {
                for (int i = 0; i < _times; i++)
                {
                    tmp /= x; tmp /= y;
                    tmp /= x; tmp /= y;
                    tmp /= x; tmp /= y;
                    tmp /= x; tmp /= y;
                    tmp /= x; tmp /= y;
                }
            }).Ticks;
        }

        private void Run(double x, double y)
        {
            // Test Add
            var tmp = ZERO_D;
            _scoreD["Add"] = Timer.Run(() =>
            {
                for (int i = 0; i < _times; i++)
                {
                    tmp += x; tmp += y;
                    tmp += x; tmp += y;
                    tmp += x; tmp += y;
                    tmp += x; tmp += y;
                    tmp += x; tmp += y;
                }
            }).Ticks;
            // Test Subtract
            tmp = ZERO_D;
            _scoreD["Sub"] = Timer.Run(() =>
            {
                for (int i = 0; i < _times; i++)
                {
                    tmp -= x; tmp -= y;
                    tmp -= x; tmp -= y;
                    tmp -= x; tmp -= y;
                    tmp -= x; tmp -= y;
                    tmp -= x; tmp -= y;
                }
            }).Ticks;
            // Test Multply
            tmp = ONE_D;
            _scoreD["Mul"] = Timer.Run(() =>
            {
                for (int i = 0; i < _times; i++)
                {
                    tmp *= x; tmp *= y;
                    tmp *= x; tmp *= y;
                    tmp *= x; tmp *= y;
                    tmp *= x; tmp *= y;
                    tmp *= x; tmp *= y;
                }
            }).Ticks;
            // Test Divide
            tmp = ONE_D;
            _scoreD["Div"] = Timer.Run(() =>
            {
                for (int i = 0; i < _times; i++)
                {
                    tmp /= x; tmp /= y;
                    tmp /= x; tmp /= y;
                    tmp /= x; tmp /= y;
                    tmp /= x; tmp /= y;
                    tmp /= x; tmp /= y;
                }
            }).Ticks;
        }

        private static Dictionary<string, long> CreateScoreDict()
        {
            return new Dictionary<string, long>
            {
                ["Add"] = 0,
                ["Sub"] = 0,
                ["Mul"] = 0,
                ["Div"] = 0
            };
        }
    }
}

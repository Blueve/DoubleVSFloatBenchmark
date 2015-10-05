using System;

namespace DoubleVSFloatBenchmark
{
    internal class Benchmark
    {
        private const float ZeroF = 0f;
        private const float OneF = 1f;

        private const double ZeroD = .0;
        private const double OneD = 1.0;

        private static int _iteration;
        
        public Benchmark(int times)
        {
            _iteration = times;
        }

        public void Excute()
        {
            // Warm up
            FloatAdd();
            FloatSub();
            FloatMul();
            FloatDiv();
            FloatMix();

            DoubleAdd();
            DoubleSub();
            DoubleMul();
            DoubleDiv();
            DoubleMix();

            // Start
            CodeTimer.Initialize();

            CodeTimer.Time("Float Add", _iteration, FloatAdd);
            CodeTimer.Time("Double Add", _iteration, DoubleAdd);

            CodeTimer.Time("Float Sub", _iteration, FloatSub);
            CodeTimer.Time("Double Sub", _iteration, DoubleSub);

            CodeTimer.Time("Float Mul", _iteration, FloatMul);
            CodeTimer.Time("Double Mul", _iteration, DoubleMul);

            CodeTimer.Time("Float Div", _iteration, FloatDiv);
            CodeTimer.Time("Double Div", _iteration, DoubleDiv);

            CodeTimer.Time("Float Mix", _iteration, FloatMix);
            CodeTimer.Time("Double Mix", _iteration, DoubleMix);
        }

        #region Test cases

        private static void FloatMix()
        {
            float x = 0.1234f, y = 4.321f;
            float a, b, c;
            a = x + y + x + y + x + y - x - y - x - y - x - y - x - y;
            b = x * x * x * x * x + y * y * y * y * y;
            c = x / y / x / y / x / y / x / y - y / x / y / x / y / x / y / x;
        }

        private static void DoubleMix()
        {
            double x = 0.1234f, y = 4.321f;
            double a, b, c;
            a = x + y + x + y + x + y - x - y - x - y - x - y - x - y;
            b = x * x * x * x * x + y * y * y * y * y;
            c = x / y / x / y / x / y / x / y - y / x / y / x / y / x / y / x;
        }


        private static void FloatAdd()
        {
            float x = 0.1234f, y = 4.321f;
            var tmp = ZeroF;
            tmp += x;
            tmp += y;
            tmp += x;
            tmp += y;
            tmp += x;
            tmp += y;
            tmp += x;
            tmp += y;
            tmp += x;
            tmp += y;
        }


        private static void DoubleAdd()
        {
            double x = 0.1234, y = 4.321;
            var tmp = ZeroD;
            tmp += x;
            tmp += y;
            tmp += x;
            tmp += y;
            tmp += x;
            tmp += y;
            tmp += x;
            tmp += y;
            tmp += x;
            tmp += y;
        }

        private static void FloatSub()
        {
            float x = 0.1234f, y = 4.321f;
            var tmp = ZeroF;
            tmp -= x;
            tmp -= y;
            tmp -= x;
            tmp -= y;
            tmp -= x;
            tmp -= y;
            tmp -= x;
            tmp -= y;
            tmp -= x;
            tmp -= y;
        }

        private static void DoubleSub()
        {
            double x = 0.1234, y = 4.321;
            var tmp = ZeroD;
            tmp -= x;
            tmp -= y;
            tmp -= x;
            tmp -= y;
            tmp -= x;
            tmp -= y;
            tmp -= x;
            tmp -= y;
            tmp -= x;
            tmp -= y;
        }

        private static void FloatMul()
        {
            float x = 0.1234f, y = 4.321f;
            var tmp = OneF;
            tmp *= x;
            tmp *= y;
            tmp *= x;
            tmp *= y;
            tmp *= x;
            tmp *= y;
            tmp *= x;
            tmp *= y;
            tmp *= x;
            tmp *= y;
        }

        private static void DoubleMul()
        {
            double x = 0.1234, y = 4.321;
            var tmp = OneD;
            tmp *= x;
            tmp *= y;
            tmp *= x;
            tmp *= y;
            tmp *= x;
            tmp *= y;
            tmp *= x;
            tmp *= y;
            tmp *= x;
            tmp *= y;
        }

        private static void FloatDiv()
        {
            float x = 0.1234f, y = 4.321f;
            var tmp = OneF;
            tmp /= x;
            tmp /= y;
            tmp /= x;
            tmp /= y;
            tmp /= x;
            tmp /= y;
            tmp /= x;
            tmp /= y;
            tmp /= x;
            tmp /= y;
        }

        private static void DoubleDiv()
        {
            double x = 0.1234, y = 4.321;
            var tmp = OneD;
            tmp /= x;
            tmp /= y;
            tmp /= x;
            tmp /= y;
            tmp /= x;
            tmp /= y;
            tmp /= x;
            tmp /= y;
            tmp /= x;
            tmp /= y;
        }

        #endregion
    }
}
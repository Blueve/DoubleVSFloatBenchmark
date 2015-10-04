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
            // 预热
            FloatAdd();
            FloatSub();
            FloatMul();
            FloatDiv();
            
            DoubleAdd();
            DoubleSub();
            DoubleMul();
            DoubleDiv();

            // 开始测试
            CodeTimer.Initialize();

            CodeTimer.Time("Float Add", _iteration, FloatAdd);
            CodeTimer.Time("Double Add", _iteration, DoubleAdd);

            CodeTimer.Time("Float Sub", _iteration, FloatSub);
            CodeTimer.Time("Double Sub", _iteration, DoubleSub);

            CodeTimer.Time("Float Mul", _iteration, FloatMul);
            CodeTimer.Time("Double Mul", _iteration, DoubleMul);

            CodeTimer.Time("Float Div", _iteration, FloatDiv);
            CodeTimer.Time("Double Div", _iteration, DoubleDiv);
        }

        #region 测试对象

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
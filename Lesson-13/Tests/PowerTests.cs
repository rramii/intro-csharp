using NUnit.Framework;

namespace Tests
{
    public class PowerTests
    {
        static int n = 1;
        Data.Algebra r;

        [SetUp]
        public void Setup()
        {
            r = new Data.Algebra();
            Console.WriteLine($"set up! {n++}");
        }

        [Test]
        public void TestPowerPositive()
        {
            int[] num = { 1, 2, 5, 9, 8, 12 };
            int[] pow = { 3, 4, 5, 9, 7, 1 };
            for (int i = 0; i < num.Length; i++)
            {
                var res = r.Power(num[i], pow[i]);
                Assert.AreEqual(Math.Pow(num[i], pow[i]), res);
            }
        }

        [Test]
        public void TestNigativePower()
        {
            int[] num = { 1, 2, 5, 9, 8, 12 };
            double[] pow = { -3, -4, -5, -9, -7, -1 };
            for (int i = 0; i < num.Length; i++)
            {
                var res = r.Power(num[i], pow[i]);
                Assert.AreEqual(Math.Pow(num[i], pow[i]), res);
            }
        }

        [Test]
        public void TestPowNigativeNumber()
        {
            int[] num = { -1, -2, -5, -9, -8, -12 };
            int[] pow = { 3, 4, 5, 9, 7, 1 };
            for (int i = 0; i < num.Length; i++)
            {
                var res = r.Power(num[i], pow[i]);
                Assert.AreEqual(Math.Pow(num[i], pow[i]), res);
            }
        }
    }
}
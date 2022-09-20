using NUnit.Framework;

namespace Tests
{
    public class MulTests
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
        public void TestMulPositive()
        {
            int[] a = { 1, 2, 5, 9, 100, 4521 };
            int[] b = { 3, 4, 5, 19, 140, 4521 };
            for (int i = 0; i < a.Length; i++)
            {
                var res = r.Mul(a[i], b[i]);
                Assert.AreEqual(a[i] * b[i], res);
            }
        }

        [Test]
        public void TestMulNegative()
        {
            int[] a = { -4, 4, -5, 9, -9, -4521 };
            int[] b = { 3, -3, -5, -1, 1, -4521 };

            for (int i = 0; i < a.Length; i++)
            {
                var res = r.Mul(a[i], b[i]);
                Assert.AreEqual(a[i] * b[i], res);
            }
        }

        [Test]
        public void TestMulby0()
        {
            
            var solution = r.Mul(5, 0);
            Assert.IsTrue(solution == 5 * 0);
            solution = r.Mul(0, 7);
            Assert.IsTrue(solution == 0 * 7);
            solution = r.Mul(0, 0);
            Assert.IsTrue(solution == 0 * 0);
        }

        [Test]
        public void TestMulUnit()
        {
            int[] a = { 1, 2, 5, 9, 100, 4521 };
            
            for (int i = 0; i < a.Length; i++)
            {
                var res = r.Mul(a[i], 1);
                Assert.That(res, Is.EqualTo(a[i]));
            }
        }
    }
}

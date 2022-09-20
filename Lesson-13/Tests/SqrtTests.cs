using NUnit.Framework;

namespace Tests
{
    internal class SqrtTests
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
        public void TestSqrtPositive()
        {
            int[] num = { 4, 9, 25, 144 };
            for (int i = 0; i < num.Length; i++)
            {
                var res = r.SquareRoot(num[i]);
                Assert.AreEqual(Math.Sqrt(num[i]), res);
            }
        }

        [Test]
        public void TestSqrtNigativeNum()
        {
            int[] num = { -4, -9, -25, -144};
            for (int i = 0; i < num.Length; i++)
            {
                var res = r.SquareRoot(num[i]);
                Assert.AreEqual(Math.Sqrt(num[i]), res);
            }
        }
    }
}

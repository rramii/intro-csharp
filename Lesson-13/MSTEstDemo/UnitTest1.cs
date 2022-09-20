namespace MSTEstDemo
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPowerZero()
        {
            var alg = new Data.Algebra();

            int[] n = { 0, 1, 2, 3, 4, 5, 100 };
            for (int i = 0; i < n.Length; i++)
            {
                var r = alg.Power(n[i], 0);
                Assert.AreEqual(1, r);
            }
        }


        [TestMethod]
        public void TestPowerOne()
        {
            var alg = new Data.Algebra();

            int[] n = { 0, 1, 2, 3, 4, 5, 100 };
            for (int i = 0; i < n.Length; i++)
            {
                var r = alg.Power(n[i], 1);
                Assert.AreEqual(n[i], r);
            }
        }


        [TestMethod]
        public void TestPowerFive()
        {
            var alg = new Data.Algebra();

            int[] n = { 0, 1, 2, 3, 4, 5, 23 };
            for (int i = 0; i < n.Length; i++)
            {
                var r = alg.Power(n[i], 5);
                Assert.AreEqual(Math.Pow(n[i], 5), r);
            }
        }

        [TestMethod]
        public void TestPowerNegativeFive()
        {
            var alg = new Data.Algebra();

            int[] n = { 0, 1, 2, 3, 4, 5, 23 };
            for (int i = 0; i < n.Length; i++)
            {
                var r = alg.Power(n[i], -5);
                Assert.AreEqual(Math.Pow(n[i], -5), r);
            }
        }


        [TestMethod]
        public void TestNegativeToPositivePower()
        {
            var alg = new Data.Algebra();

            int[] n = { 0, 1, 2, 3, 4, 5, 23 };
            for (int i = 0; i < n.Length; i++)
            {
                var r = alg.Power(-n[i], 5);
                Assert.AreEqual(Math.Pow(-n[i], 5), r);
            }
        }
    }
}
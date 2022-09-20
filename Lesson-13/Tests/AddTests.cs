using NUnit.Framework;

namespace Tests
{
    public class AddTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAddPostive()
        {
            var r = new Data.Algebra();
            var solution = r.Add(4, 4);
            Assert.IsTrue(solution == 4 + 4);
            solution = r.Add(7, 10);
            Assert.IsTrue(solution == 7 + 10);
            solution = r.Add(24, 50);
            Assert.IsTrue(solution == 24 + 50);
        }
        
        [Test]
        public void TestAddNegatives()
        {
            var r = new Data.Algebra();
            var solution = r.Add(5, -7);
            Assert.AreEqual(-2, solution);
            solution = r.Add(-6, 3);
            Assert.AreEqual(solution, 3 - 6);
            solution = r.Add(-8, -7);
            Assert.IsTrue(solution == -(8+7));
        }

        [Test]
        public void TestAdd0()
        {
            var r = new Data.Algebra();
            var solution = r.Add(0, 7);
            Assert.IsTrue(solution == 0 + 7);
            solution = r.Add(8, 0);
            Assert.IsTrue(solution == 8 + 0);
            solution = r.Add(0, 0);
            Assert.IsTrue(solution == 0 + 0);
        }
    }
}
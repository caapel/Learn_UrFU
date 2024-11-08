using LibExample;

namespace QuadEq.Tests
{
    [TestFixture]
    public class SolverTest
    {
        public void TestEquation(double a, double b, double c, params double[] expectedResult)
        {
            var result = QuadraticEquation.Solve(a, b, c);

            Assert.AreEqual(expectedResult.Length, result.Length);

            for (int i = 0; i < result.Length; i++) 
                Assert.AreEqual(expectedResult[i], result[i]);
        }
        
        [Test]
        public void OrdinatyEquation()
        {
            TestEquation(1, -3, 2, 2, 1);
        }

        [Test]
        public void ZeroDiscriminant()
        {
            TestEquation(1, 2, 1, -1);
        }

        [Test]
        public void NegativeDiscriminant()
        {
            TestEquation(1, 1, 1);
        }

        [Test]
        public void FunctionalTest()
        {
            for (int i = 0; i < 100;i++) 
            {
                var rnd = new Random();

                double a = rnd.NextDouble() * 10, 
                       b = rnd.NextDouble() * 10, 
                       c = rnd.NextDouble() * 10;

                var result = QuadraticEquation.Solve(a, b, c);

                foreach (var x in result)
                    Assert.AreEqual(0, a * x * x + b * x + c, 1e-10);
            }
        }
    }
}
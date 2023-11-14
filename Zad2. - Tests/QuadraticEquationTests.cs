using Zad2.QuadraticEquation;

namespace Zad2.__Test_Project
{
    [TestClass]
    public class QuadraticEquationTests
    {
        [TestMethod]
        public void Roots_Method_Test()
        {
            //Set values
            QuadraticEquation.QuadraticEquation first = new QuadraticEquation.QuadraticEquation(1, 2, -3);
            QuadraticEquation.QuadraticEquation second = new QuadraticEquation.QuadraticEquation(-1, 2, -1);
            double[] firstExpected = new double[2] { 1, -3 };
            double[] secondExpected = new double[2] { 1, 1 };

            //Get values
            double[] rootsFirst = first.Roots;
            double[] rootsSecond = second.Roots;

            //Test results
            CollectionAssert.AreEqual(firstExpected, rootsFirst, "Prvi korjeni su krivi");
            CollectionAssert.AreEqual(secondExpected, rootsSecond, "Drugi korjeni su krivi");
        }

        [TestMethod()]
        [ExpectedException(typeof(NotRealRootsException))]
        public void NotRealRootExceptionTest()
        {
            QuadraticEquation.QuadraticEquation testament = new QuadraticEquation.QuadraticEquation(1, 0, 1);
            double[] roots = testament.Roots;
        }
    }
}
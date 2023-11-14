using Zad2.QuadraticEquation;
using Zad2_3.QuadraticEquation.Structs;

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


        [TestClass]
        public class ComplexTests
        {
            [TestMethod()]
            public void ComplexOperations()
            {
                //Set values
                Complex first = new Complex(1, 2);
                Complex second = new Complex(3, 4);
                Complex third = new Complex(2, 1);
                Complex fourth = new Complex(5, 5);

                //Test results
                Assert.AreEqual(new Complex(4, 6), first + second, "Addition error");
                Assert.AreEqual(new Complex(1, 3), second - third, "Subtraction error");
                Assert.AreEqual(new Complex(-5, -2), first * second, "Multiplication error");
                Assert.AreEqual(new Complex(3, -1), fourth / first, "Division error");


            }
        }

    }
}
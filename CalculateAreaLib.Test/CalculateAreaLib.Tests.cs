using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculateAreaLib;

namespace CalculateAreaLib.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCircleArea1()
        {
            Circle circle = new Circle(5);
            double expectedArea = 78.54;
            double actualArea = circle.GetArea();
            Assert.AreEqual(expectedArea, actualArea, 0.01);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCircleArea2()
        {
            Circle circle = new Circle(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCircleArea3()
        {
            Circle circle = new Circle(0);
        }

        [TestMethod]

        public void TestTriangleArea1()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            double expectedArea = 6;
            double actualArea = triangle.GetArea();
            Assert.AreEqual(expectedArea, actualArea, 0.01);
        }

        [TestMethod]
        public void TestTriangleIsRightTrue()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRightTriangle());
        }

        [TestMethod]
        public void TestTriangleIsRightFalse()
        {
            Triangle triangle = new Triangle(7, 16, 13);
            Assert.IsFalse(triangle.IsRightTriangle());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTriangleAreaException1()
        {
            Triangle triangle = new Triangle(0, 1, 4);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTriangleAreaException2()
        {
            Triangle triangle = new Triangle(6, 18, 11);
        }
    }
}
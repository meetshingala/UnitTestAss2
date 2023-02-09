using NUnit.Framework;

namespace CircleTest
{
    public class Class1
    {
        Circle circle = new Circle();
        [NUnit.Framework.SetUp]
        public void Setup()
        {
            Circle circle = new Circle(5);
        }

        [Test]
        public void GetRadius_SetRadius0_Return0()
        {
            circle.SetRadius(0);
            int expectedResult = 0;
            int actualResult = circle.GetRadius();
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetRadius_SetRadiusMinus1_ReturnsMinus1()
        {
            circle.SetRadius(-1);
            int expectedResult = -1;
            int actualResult = circle.GetRadius();
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetRadius_SetRadius10_Returns10()
        {
            circle.SetRadius(10);
            int expectedResult = 10;
            int actualResult = circle.GetRadius();
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void SetRadius_SetRadius28_Returns28()
        {
            int expectedResult = 28;
            circle.SetRadius(28);
            int actualResult = circle.GetRadius();
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void SetRadius_SetRadius0_Returns0()
        {
            int expectedResult = 0;
            circle.SetRadius(0);
            int actualResult = circle.GetRadius();
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void SetRadius_SetRadiusMinus12_ReturnsMinus12()
        {
            int expectedResult = -12;
            circle.SetRadius(-12);
            int actualResult = circle.GetRadius();
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetCircumference_SetRadiusMinus6_Returns37Point69()
        {
            circle.SetRadius(-6);
            double expectedResult = -37.69;
            double actualResult = circle.GetCircumference();
            Assert.AreEqual(expectedResult, actualResult, 0.01);
        }
        [Test]
        public void GetCircumference_SetRadius7_Returns43Point98()
        {
            circle.SetRadius(7);
            double expectedResult = 43.98;
            double actualResult = circle.GetCircumference();
            Assert.AreEqual(expectedResult, actualResult, 0.01);
        }
        [Test]
        public void GetCircumference_SetRadius0_Returns0()
        {
            circle.SetRadius(0);
            double expectedResult = 0;
            double actualResult = circle.GetCircumference();
            Assert.AreEqual(expectedResult, actualResult, 0.01);
        }
        [Test]
        public void GetArea_SetRadius0_Returns0()
        {
            circle.SetRadius(0);
            double expectedResult = 0;
            double actualResult = circle.GetArea();
            Assert.AreEqual(expectedResult, actualResult, 0.01);
        }
        [Test]
        public void GetArea_SetRadius12_Returns452Point39()
        {
            circle.SetRadius(12);
            double expectedResult = 452.39;
            double actualResult = circle.GetArea();
            Assert.AreEqual(expectedResult, actualResult, 0.01);
        }
        [Test]
        public void GetArea_SetRadiusMinus11_Returns380Point13()
        {
            circle.SetRadius(-11);
            double expectedResult = 380.13;
            double actualResult = circle.GetArea();
            Assert.AreEqual(expectedResult, actualResult, 0.01);
        }
    }
}

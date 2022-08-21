using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuakeWaveGenerator.utility;

namespace QuakeWaveGeneratorTest
{
    [TestClass]
    public class CubeVerticesCalculatorTest
    {
        [TestMethod]
        public void Instance_CalledWithNoOffsetAndSpacing_ReturnsExpectedCoordinates()
        {
            // Arrange/Act
            CubeVerticesCalculator cubeVerticesCalculator = new CubeVerticesCalculator(1, 1, 64, 0, 0, 0, 0);

            // Assert
            Assert.AreEqual(0, cubeVerticesCalculator.LeftFrontBottom_X);
            Assert.AreEqual(0, cubeVerticesCalculator.LeftFrontBottom_Y);
            Assert.AreEqual(0, cubeVerticesCalculator.LeftFrontBottom_Z);

            Assert.AreEqual(64, cubeVerticesCalculator.RightFrontBottom_X);
            Assert.AreEqual(0, cubeVerticesCalculator.RightFrontBottom_Y);
            Assert.AreEqual(0, cubeVerticesCalculator.RightFrontBottom_Z);

            Assert.AreEqual(0, cubeVerticesCalculator.LeftBackBottom_X);
            Assert.AreEqual(64, cubeVerticesCalculator.LeftBackBottom_Y);
            Assert.AreEqual(0, cubeVerticesCalculator.LeftBackBottom_Z);

            Assert.AreEqual(64, cubeVerticesCalculator.RightBackBottom_X);
            Assert.AreEqual(64, cubeVerticesCalculator.RightBackBottom_Y);
            Assert.AreEqual(0, cubeVerticesCalculator.RightBackBottom_Z);

            Assert.AreEqual(0, cubeVerticesCalculator.LeftFrontTop_X);
            Assert.AreEqual(0, cubeVerticesCalculator.LeftFrontTop_Y);
            Assert.AreEqual(64, cubeVerticesCalculator.LeftFrontTop_Z);

            Assert.AreEqual(64, cubeVerticesCalculator.RightFrontTop_X);
            Assert.AreEqual(0, cubeVerticesCalculator.RightFrontTop_Y);
            Assert.AreEqual(64, cubeVerticesCalculator.RightFrontTop_Z);

            Assert.AreEqual(0, cubeVerticesCalculator.LeftBackTop_X);
            Assert.AreEqual(64, cubeVerticesCalculator.LeftBackTop_Y);
            Assert.AreEqual(64, cubeVerticesCalculator.LeftBackTop_Z);

            Assert.AreEqual(64, cubeVerticesCalculator.RightBackTop_X);
            Assert.AreEqual(64, cubeVerticesCalculator.RightBackTop_Y);
            Assert.AreEqual(64, cubeVerticesCalculator.RightBackTop_Z);
        }

        [TestMethod]
        public void LeftFrontBottomX_CalledWithOffsetAndSpacing_ReturnsExpectedCoordinate()
        {
            // Arrange/Act
            CubeVerticesCalculator cubeVerticesCalculator = new CubeVerticesCalculator(1, 1, 64, 8, 1, 2, 3);

            // Assert
            Assert.AreEqual(1, cubeVerticesCalculator.LeftFrontBottom_X);
            Assert.AreEqual(2, cubeVerticesCalculator.LeftFrontBottom_Y);
            Assert.AreEqual(3, cubeVerticesCalculator.LeftFrontBottom_Z);

            Assert.AreEqual(65, cubeVerticesCalculator.RightFrontBottom_X);
            Assert.AreEqual(2, cubeVerticesCalculator.RightFrontBottom_Y);
            Assert.AreEqual(3, cubeVerticesCalculator.RightFrontBottom_Z);

            Assert.AreEqual(1, cubeVerticesCalculator.LeftBackBottom_X);
            Assert.AreEqual(66, cubeVerticesCalculator.LeftBackBottom_Y);
            Assert.AreEqual(3, cubeVerticesCalculator.LeftBackBottom_Z);

            Assert.AreEqual(65, cubeVerticesCalculator.RightBackBottom_X);
            Assert.AreEqual(66, cubeVerticesCalculator.RightBackBottom_Y);
            Assert.AreEqual(3, cubeVerticesCalculator.RightBackBottom_Z);

            Assert.AreEqual(1, cubeVerticesCalculator.LeftFrontTop_X);
            Assert.AreEqual(2, cubeVerticesCalculator.LeftFrontTop_Y);
            Assert.AreEqual(67, cubeVerticesCalculator.LeftFrontTop_Z);

            Assert.AreEqual(65, cubeVerticesCalculator.RightFrontTop_X);
            Assert.AreEqual(2, cubeVerticesCalculator.RightFrontTop_Y);
            Assert.AreEqual(67, cubeVerticesCalculator.RightFrontTop_Z);

            Assert.AreEqual(1, cubeVerticesCalculator.LeftBackTop_X);
            Assert.AreEqual(66, cubeVerticesCalculator.LeftBackTop_Y);
            Assert.AreEqual(67, cubeVerticesCalculator.LeftBackTop_Z);

            Assert.AreEqual(65, cubeVerticesCalculator.RightBackTop_X);
            Assert.AreEqual(66, cubeVerticesCalculator.RightBackTop_Y);
            Assert.AreEqual(67, cubeVerticesCalculator.RightBackTop_Z);
        }
    }
}

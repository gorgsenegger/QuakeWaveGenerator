using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuakeWaveGenerator;
using System.Linq;

namespace QuakeWaveGeneratorTest
{
    [TestClass]
    public class MapFileToolTest
    {
        private readonly MapFileTool m_MapFileTool = new MapFileTool();

        [TestMethod]
        public void StepSequence_CalledWithValidArguments_ReturnsExpectedResult()
        {
            // Arrange
            // Act
            int[] sequence = m_MapFileTool.StepSequence(3, 3);

            // Assert
            Assert.AreEqual(6, sequence.Length);
            Assert.AreEqual(0, sequence[0]);
            Assert.AreEqual(9, sequence.Max());
        }

        [TestMethod]
        public void StepSequence_CalledWithZeroNumberOfSteps_ReturnsEmptyArray()
        {
            int[] sequence = m_MapFileTool.StepSequence(0, 3);

            // Assert
            Assert.AreEqual(0, sequence.Length);
        }

        [TestMethod]
        public void GenerateBaseTargetName_CalledWithRowAndColumN_ReturnsExpectedResult()
        {
            int row = 8;
            int column = 9;
            string result = m_MapFileTool.GenerateBaseTargetName(row, column);
            Assert.AreEqual("train_row-" + row.ToString("D3") + "_column-" + column.ToString("D3"), result);
        }


        //[TestMethod, ExpectedException(typeof(ArgumentException))]
        //public void GeneratePathCorner_CalledWithInvalidPathCornerTypeValue_ThrowsArgumentException()
        //{
        //    m_MapFileTool.GeneratePathCorner("", PathCornerType.None, 0, 0, 0);
        //}

        //[TestMethod]
        //public void GeneratePathCorner_CalledWithPathCornerTypeInit_ReturnsExpectedResult()
        //{
        //    string result = m_MapFileTool.GeneratePathCorner("", PathCornerType.Init, 0, 0, 0);
        //    Assert.IsTrue(result.Contains("_init"));
        //    Assert.IsTrue(result.Contains("_bottom"));
        //}

        //[TestMethod]
        //public void GeneratePathCorner_CalledWithPathCornerTypeBottom_ReturnsExpectedResult()
        //{
        //    const string basename = "MyBase";
        //    string result = m_MapFileTool.GeneratePathCorner(basename, PathCornerType.Bottom, 0, 0, 0);
        //    Assert.IsTrue(result.Contains("\"targetname\" \"" + basename + "_bottom\""));
        //    Assert.IsTrue(result.Contains("\"target\" \"" + basename + "_top\""));
        //}

        //[TestMethod]
        //public void GeneratePathCorner_CalledWithPathCornerTypeTop_ReturnsExpectedResult()
        //{
        //    const string basename = "MyBase";
        //    string result = m_MapFileTool.GeneratePathCorner(basename, PathCornerType.Top, 0, 0, 0);
        //    Assert.IsTrue(result.Contains("\"targetname\" \"" + basename + "_top\""));
        //    Assert.IsTrue(result.Contains("\"target\" \"" + basename + "_bottom\""));
        //}

        //[TestMethod]
        //public void GeneratePathCorner_CalledWithCoordinates_ReturnsExpectedResult()
        //{
        //    const string basename = "MyBase";
        //    string result = m_MapFileTool.GeneratePathCorner(basename, PathCornerType.Top, 1, 2, 3);
        //    Assert.IsTrue(result.Contains("\"origin\" \"1 2 3\""));
        //}
    }
}

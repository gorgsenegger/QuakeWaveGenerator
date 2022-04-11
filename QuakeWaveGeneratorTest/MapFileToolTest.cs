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
    }
}

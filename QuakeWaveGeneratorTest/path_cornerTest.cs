using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuakeWaveGenerator.entities;

namespace QuakeWaveGeneratorTest
{
    [TestClass]
#pragma warning disable IDE1006 // Naming Styles
    public class path_cornerTest
#pragma warning restore IDE1006 // Naming Styles
    {
        [TestMethod]
        public void ToString_Called_ReturnsExpectedObject()
        {
            path_corner path_Corner = new path_corner("myBaseTarget", QuakeWaveGenerator.PathCornerType.Bottom, 1, 1, 1);
            string result = path_Corner.ToString();

            Assert.IsTrue(result.Contains("\"classname\" \"path_corner\""));
            Assert.IsTrue(result.Contains("\"targetname\" \"myBaseTarget_bottom\""));
            Assert.IsTrue(result.Contains("\"target\" \"myBaseTarget_top\""));
            Assert.IsTrue(result.Contains("\"origin\" \"1 1 1\""));
        }
    }
}

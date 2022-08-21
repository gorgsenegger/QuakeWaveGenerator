using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuakeWaveGenerator.entities;
using System;

namespace QuakeWaveGeneratorTest
{
    [TestClass]
#pragma warning disable IDE1006 // Naming Styles
    public class func_trainTest
#pragma warning restore IDE1006 // Naming Styles
    {
        private func_train m_func_train;

        [TestInitialize]
        public void TestInitialize()
        {
            m_func_train = new func_train(1, 1, 64, 0, 0, 0, 4, "baseTargetName", true, "MyTopTexture", 32);
        }

        [TestMethod]
        public void Constructor_CalledWithValidData_ReturnsExpectedObject()
        {

        }

        [TestMethod]
        public void ToString_Called_ReturnsExpectedResult()
        {
            string result = m_func_train.ToString();
            Assert.AreEqual("x", result);
        }

        [TestMethod]
        public void GenerateFace_CalledWithValidData_ReturnsExpectedResult()
        {
            string result = m_func_train.GenerateFace(0, 0, 0, 64, 0, 0, 0, 0, 64, "MyTopTexture");
            Assert.AreEqual("    (0000 0000 0000) (0064 0000 0000) (0000 0000 0064) MyTopTexture 0 0 0 1 1" + Environment.NewLine, result);
        }
    }
}

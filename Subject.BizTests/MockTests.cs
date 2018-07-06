using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Subject.BizTests
{
    [TestClass]
    public class MockTests
    {
        [TestMethod]
        public void MockTest1()
        {
            //Arrange
            var expected = "Result Expected";
            //Act
            var result = "Result Expected";
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}

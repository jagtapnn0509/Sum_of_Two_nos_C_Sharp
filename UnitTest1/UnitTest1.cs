﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumOfTwoNumbers;
using System;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //AAA
            //Arrange
            Program program = new Program();

            //Act
            int result = program.Add(5, 10);

            //Assert
            Assert.AreEqual(15, result);
 
        }
    }
}

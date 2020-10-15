using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;
using System;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.
        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }
        [TestMethod]
        public void SingleBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]"));
        }
        [TestMethod]
        public void TwoBracketsReturnsFalse()
        {
           Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[LaunchCode"));
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[["));
        }
        [TestMethod]
        public void twoBracketsReturnsInOppositFalse()
        {

            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }
        [TestMethod]
        public void testForGrowingbrackets()
        {
            
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[][]"));
        }
        [TestMethod]
        public void testForNestedbrackets()
        {

            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[]]"));
        }
        [TestMethod]
        public void TwoBracketsReturnsTrue()
        {
            
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[LaunchCode]"));
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[LaunchCode][]"));


        }
        [TestMethod]
        public void TwoBracketsReturnsTrue1()
        {

            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[LaunchCode][]"));
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[LaunchCode][]"));


        }
        [TestMethod]
        public void strOneReturnsTrue()
        {

            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("1"));
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("111111111111"));


        }
        [TestMethod]
        public void stringForOnlyLettersReturnsTrue()
        {

            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("A"));
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("adggdgffddjhd"));


        }
        [TestMethod]
        public void spaceTestReturnTrue()
        {

            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("          "));
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));


        }
        [TestMethod]
        public void stringFalseReturnTrue()
        {

            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("false"));
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("               false"));


        }





        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }
    }
}

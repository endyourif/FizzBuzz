using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class FizzBuzzTests
    {
        private FizzBuzz _fizzBuzz;

        public FizzBuzzTests()
        {
            _fizzBuzz = new FizzBuzz();
        }

        [TestMethod]
        public void Given1Expect1()
        {
            const int expected = 1;
            var actual = _fizzBuzz.Calculate(1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Given3ExpectFizz()
        {
            const string expected = "Fizz";
            var actual = _fizzBuzz.Calculate(3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Given5ExpectBuzz()
        {
            const string expected = "Buzz";
            var actual = _fizzBuzz.Calculate(5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Given15Expect_FizzBuzz()
        {
            const string expected = "FizzBuzz";
            var actual = _fizzBuzz.Calculate(15);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Given0ExpectException()
        {
            _fizzBuzz.Calculate(0);
        }
    }
}

using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WNG.Sequence.Models;

namespace WNG.Sequence.UnitTests.Models
{
    [TestFixture]
    public class SequenceCalculatorTests
    {
        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Calculate_Invalid()
        {
            var sut = new SequenceCalculator();
            var result = sut.Calculate(0);
        }

        [Test]
        public void Calculate_NumberSequence_Test()
        {
            var sut = new SequenceCalculator();
            var result = sut.Calculate(5);

            var expected = new List<int> { 1, 2, 3, 4, 5 };
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.NumberSequence);
            CollectionAssert.AreEqual(expected, result.NumberSequence);
        }

        [Test]
        public void Calculate_OddSequence_Test()
        {
            var sut = new SequenceCalculator();
            var result = sut.Calculate(5);

            var expected = new List<int> { 1, 3, 5 };
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.OddSequence);
            CollectionAssert.AreEqual(expected, result.OddSequence);
        }

        [Test]
        public void Calculate_EvenSequence_Test()
        {
            var sut = new SequenceCalculator();
            var result = sut.Calculate(5);

            var expected = new List<int> { 2, 4 };
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.EvenSequence);
            CollectionAssert.AreEqual(expected, result.EvenSequence);
        }

        [Test]
        public void Calculate_CustomSequence_Test()
        {
            var sut = new SequenceCalculator();
            var result = sut.Calculate(5);

            var expected = new List<string> { "1", "2", "C", "4" };
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.CustomSequence);
            CollectionAssert.AreEqual(expected, result.CustomSequence);
        }

        [Test]
        public void Calculate_FibinachiSequence_Test()
        {
            var sut = new SequenceCalculator();
            var result = sut.Calculate(5);

            var expected = new List<int> { 1, 1, 2, 3, 5};
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.FibinachiSequence);
            CollectionAssert.AreEqual(expected, result.FibinachiSequence);
        }
    }
}

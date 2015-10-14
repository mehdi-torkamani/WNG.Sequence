using NUnit.Framework;

namespace WNG.Sequence.UnitTests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void InitialTest()
        {
            var sut = 0;
            Assert.That(sut, Is.EqualTo(0));
        }
    }
}

using NUnit.Framework;
using OpenQA.Selenium;
using WNG.Sequence.Controllers;
using WNG.Sequence.UITests.PageModels;

namespace WNG.Sequence.UITests
{
    [TestFixture]
    public class SequenceTests
    {
        [Test]
        public void AcceptValidNumber()
        {
            var home = Host.Instance.NavigateToInitialPage<HomeController, HomePage>(x => x.Index());
            var createSequence = home.Start();
            var showResult = createSequence.EnterNumber(12).GenerateValid();

            Assert.That(showResult.Number, Is.EqualTo("12"));
            Assert.That(showResult.NumberSequence, Is.Not.Empty);
            Assert.That(showResult.OddSequence, Is.Not.Empty);
            Assert.That(showResult.EvenSequence, Is.Not.Empty);
            Assert.That(showResult.CustomSequence, Is.Not.Empty);
            Assert.That(showResult.FibinachiSequence, Is.Not.Empty);
        }

        [Test]
        public void AcceptInValidNumber()
        {
            var home = Host.Instance.NavigateToInitialPage<HomeController, HomePage>(x => x.Index());
            var createSequence = home.Start();
            var showResult = createSequence.EnterNumber(-1).GenerateInValid();

            Assert.That(showResult.Number, Is.EqualTo("-1"));
            Assert.That(showResult.Error, Is.Not.Empty);
        }
    }
}

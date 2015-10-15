using NUnit.Framework;
using System.Web.Mvc;
using TestStack.FluentMVCTesting;
using WNG.Sequence.Controllers;
using WNG.Sequence.Models;

namespace WNG.Sequence.UnitTests.Controllers
{
    [TestFixture]
    public class HomeControllerTests
    {
        [Test]
        public void Home_View()
        {
            HomeController sut = new HomeController();
            sut.WithCallTo(x => x.Index()).ShouldRenderDefaultView();
        }
    }
}

using NUnit.Framework;
using System.Net;
using System.Web.Mvc;
using TestStack.FluentMVCTesting;
using WNG.Sequence.Controllers;
using WNG.Sequence.Models;

namespace WNG.Sequence.UnitTests.Controllers
{
    [TestFixture]
    public class SequenceControllerTests
    {
        [Test]
        public void CreateSequence_View_Get()
        {
            SequenceController sut = new SequenceController();

            sut.WithCallTo(x => x.CreateSequence()).ShouldRenderDefaultView();
        }

        [Test]
        public void CreateSequence_View_Post()
        {
            SequenceRequest request = new SequenceRequest() { Number = 10 };
            SequenceController sut = new SequenceController();

            sut.WithCallTo(x => x.CreateSequence(request)).ShouldRedirectTo<int>(x => x.ShowResult);
        }

        [Test]
        public void ShowResult_View()
        {
            SequenceController sut = new SequenceController();

            sut.WithCallTo(x => x.ShowResult(12)).ShouldRenderDefaultView().WithModel<SequenceResult>(x => x.Number == 12);
        }

        [Test]
        public void ShowResult_View_Invalid()
        {
            SequenceController sut = new SequenceController();

            sut.WithCallTo(x => x.ShowResult(-1)).ShouldGiveHttpStatus(HttpStatusCode.BadRequest);
        }
    }
}

using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.Seleno.PageObjects;

namespace WNG.Sequence.UITests.PageModels
{
    public class ShowResultPage : Page
    {
        public string Number { get { return Find.Element(By.Id("number")).Text; } }
        public string NumberSequence { get { return Find.Element(By.Id("numberSequence")).Text; } }
        public string OddSequence { get { return Find.Element(By.Id("oddSequence")).Text; } }
        public string EvenSequence { get { return Find.Element(By.Id("evenSequence")).Text; } }
        public string CustomSequence { get { return Find.Element(By.Id("customSequence")).Text; } }
        public string FibinachiSequence { get { return Find.Element(By.Id("fibinachiSequence")).Text; } }
    }
}

using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.Seleno.PageObjects;

namespace WNG.Sequence.UITests.PageModels
{
    public class CreateSequencePage : Page
    {
        public string Number { get { return Find.Element(By.Id("Number")).GetAttribute("value"); } }
        public string Error { get { return Find.Element(By.Id("errNumber")).Text; } }

        public CreateSequencePage EnterNumber(int number)
        {
            Find.Element(By.Id("Number")).SendKeys(number.ToString());
            return this;
        }

        public ShowResultPage GenerateValid()
        {
            return Navigate.To<ShowResultPage>(By.Id("btnGenerate"));
        }

        public CreateSequencePage GenerateInValid()
        {
            return Navigate.To<CreateSequencePage>(By.Id("btnGenerate"));
        }
    }
}

using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.Seleno.PageObjects;

namespace WNG.Sequence.UITests.PageModels
{
    public class HomePage : Page
    {
        public CreateSequencePage Start()
        {
            return Navigate.To<CreateSequencePage>(By.Id("btnStart"));
        }
    }
}

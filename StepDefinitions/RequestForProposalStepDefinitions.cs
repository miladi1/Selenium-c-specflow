using DotNetEnv;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using TestOptima.PageObjects;
using TestOptima.Utilities;


namespace TestOptima.StepDefinitions
{
    [Binding]
    public class RequestForProposalStepDefinitions
    {
        private readonly ProposalPage proposalpage;
        private readonly LoginPage loginPage;

        private readonly IWebDriver Driver;
        public RequestForProposalStepDefinitions(IWebDriver Driver)
        {
            this.Driver = Driver;
            Utilities.Env.Load(); // Load config.json file
            this.proposalpage = new ProposalPage(Driver);

        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            Utilities.Env.Load(); // Load environment variables from .env file
        }

        [Given(@"I click on proposal Requests")]
        public void GivenIClickOnProposalRequests()
        {
            proposalpage.ProposalsRequests();
        }

        [When(@"I click on Create proposal")]
        public void WhenIClickOnCreateProposal()
        {
            proposalpage.CreateProposalsRequests();
        }

        [When(@"I enter the proposal title")]
        public void WhenIEnterTheProposalTitle()
        {
            string Title = Utilities.Env.GetVariable("Title");
            proposalpage.Title(Title);
        }

        [When(@"I select the categorie")]
        public void WhenISelectTheCategorie()
        {
            proposalpage.Category();
           }

        [When(@"I enter the submission")]
        public void WhenIEnterTheSubmission()
        {
            string Submission = Utilities.Env.GetVariable("Submission");
            proposalpage.Submission(Submission);
        }

        [When(@"I enter the deadLine")]
        public void WhenIEnterTheDeadLine()
        {
            string Deadline = Utilities.Env.GetVariable("Deadline");
            proposalpage.Deadline(Deadline);
        }

        [When(@"I check the status checkbox")]
        public void WhenICheckTheStatusCheckbox()
        {
            proposalpage.StatusCheck();
        }

        [When(@"I click on Save")]
        public void WhenIClickOnSave()
        {
            proposalpage.Savebuuton();
        }

        [Then(@"the proposal request should be saved successfully")]
        public void ThenTheProposalRequestShouldBeSavedSuccessfully()
        {
            proposalpage.AssertSave();
        }
    }
}

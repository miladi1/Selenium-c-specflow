using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using TestOptima.PageObjects;
using TestOptima.Utilities;

namespace TestOptima.StepDefinitions
{
    [Binding]
    public class RequestForProposalUpdateStepDefinitions
    {
        private readonly IWebDriver Driver;
        private readonly ProposalPage proposalPage;
        public RequestForProposalUpdateStepDefinitions(IWebDriver Driver)
        {
            this.Driver = Driver;
            Env.Load(); // Load config.json file
            this.proposalPage = new ProposalPage(Driver);

        }
        [Given(@"I click on Prop Request")]
        public void GivenIClickOnPropRequest()
        {
            proposalPage.ProposalsRequests();
        }

        [When(@"I click on Action to edit")]
        public void WhenIClickOnActionToEdit()
        {
            proposalPage.Action();
        }

        [When(@"I click on edit button")]
        public void WhenIClickOnEditButton()
        {
            proposalPage.EditUpdate();
        }

        [When(@"I update title")]
        public void WhenIUpdateTitle()
        {
            string Title = Utilities.Env.GetVariable("Title");
            proposalPage.entertitle(Title);
        }

        [When(@"I update submission")]
        public void WhenIUpdateSubmission()
        {
            string submission = Utilities.Env.GetVariable("Submission");
            proposalPage.enterSubmission(submission);

        }

        [When(@"i update categorie")]
        public void WhenIUpdateCategorie()
        {
            proposalPage.Catgoryupdate();
        }

        [When(@"i update deadline")]
        public void WhenIUpdateDeadline()
        {
            string deadline = Utilities.Env.GetVariable("Deadline");
            proposalPage.enterDeadline(deadline);

        }

        [When(@"i update status")]
        public void WhenIUpdateStatus()
        {
            proposalPage.UpdateStatus();
        }

        [When(@"I click on Save to to update")]
        public void WhenIClickOnSaveToToUpdate()
        {
            proposalPage.saveUpdate();
        }

        [Then(@"the proposal request should be updated successfully")]
        public void ThenTheProposalRequestShouldBeUpdatedSuccessfully()
        {
            proposalPage.AssertUpdate();
        }
    }
}

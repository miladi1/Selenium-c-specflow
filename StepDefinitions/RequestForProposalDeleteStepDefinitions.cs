using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using TestOptima.PageObjects;

namespace TestOptima.StepDefinitions
{
    [Binding]
    public class RequestForProposalDeleteStepDefinitions
    {
        private readonly ProposalPage proposalPage;
        private readonly IWebDriver Driver;

        public RequestForProposalDeleteStepDefinitions(IWebDriver Driver)
        {
            this.Driver = Driver;
            this.proposalPage = new ProposalPage(Driver);

        }
        [Given(@"I click on proposal Request Homepage")]
        public void GivenIClickOnProposalRequestHomepage()
        {
            proposalPage.ProposalsRequests();
        }

        [When(@"I clicked on Action to delete")]
        public void WhenIClickedOnActionToDelete()
        {
            proposalPage.Action();
        }

        [When(@"I click on delete button")]
        public void WhenIClickOnDeleteButton()
        {
            proposalPage.DeleteProposal();
        }

        [When(@"I click on Confirme Delete")]
        public void WhenIClickOnConfirmeDelete()
        {
            proposalPage.ConfirmDelete();

        }

        [Then(@"the proposal request should be Deleted successfully")]
        public void ThenTheProposalRequestShouldBeDeletedSuccessfully()
        {
            proposalPage.AssertDelete();
        }
    }
}

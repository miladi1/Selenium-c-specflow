using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;

namespace TestOptima.PageObjects
{
    public class ProposalPage
    {
        private WebDriverWait wait;
        private readonly IWebDriver Driver;
        public ProposalPage(IWebDriver Driver)
        {
            this.Driver = Driver;
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.Zero;
            wait = new WebDriverWait(Driver, TimeSpan.Zero);
        }
        public void WaitForElementToBeVisible(By locator)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }
        public IWebElement ProposalsRequestsButton => Driver.FindElement(By.Id("RequestsForProposal"));
        public IWebElement CreateProposalRequestButton => Driver.FindElement(By.CssSelector("#Createrequestforproposal"));
        public IWebElement TitleInput => Driver.FindElement(By.Id("Title"));
        public IWebElement ClickCategoryInput => Driver.FindElement(By.Id("Category"));
        public IWebElement CategorylistInput => Driver.FindElement(By.Id("0"));
        public IWebElement SubmissionInput => Driver.FindElement(By.Id("Submission"));
        public IWebElement DeadlineInput => Driver.FindElement(By.CssSelector("#Deadline"));
        public IWebElement StatusInput => Driver.FindElement(By.CssSelector("#Open"));
        public IWebElement SaveProp => Driver.FindElement(By.Id("Save&Showlist"));
        public IWebElement Action0 => Driver.FindElement(By.Id("Action0"));
        public IWebElement Edit => Driver.FindElement(By.Id("Edit"));
        public IWebElement Delete => Driver.FindElement(By.Id("Delete"));
        public IWebElement ConfirmDeleteProp => Driver.FindElement(By.Id("Yes,Delete"));
        public IWebElement titleUpdate => Driver.FindElement(By.Id("title"));
        public IWebElement submissionsUpdate => Driver.FindElement(By.Id("submissions"));
        public IWebElement CategoryUpdate => Driver.FindElement(By.Id("Category"));
        public IWebElement DeadlineUpdate => Driver.FindElement(By.Id("Deadline"));
        public IWebElement StatusUpdate => Driver.FindElement(By.Id("Closed"));
        public IWebElement SaveUpdate => Driver.FindElement(By.Id("Save"));
        public IWebElement popup => Driver.FindElement(By.CssSelector(".v-alert"));



        public void ProposalsRequests()
        {

            ProposalsRequestsButton.Click();
        }
        public void CreateProposalsRequests()
        {

            CreateProposalRequestButton.Click();
        }
        public void StatusCheck()
        {

            StatusInput.Click();
        }
        public void Title(string Title)
        {
            Title = TestOptima.Utilities.Env.GetVariable("Title");
            WaitForElementToBeVisible(By.CssSelector("Title"));
            TitleInput.SendKeys(Title);

        }
        public void Deadline(string Deadline)
        {
            Deadline = TestOptima.Utilities.Env.GetVariable("Deadline");
            WaitForElementToBeVisible(By.CssSelector("Deadline"));
            TitleInput.SendKeys(Deadline);

        }
        public void Submission(string Submission)
        {
            Submission = TestOptima.Utilities.Env.GetVariable("Submission");
            WaitForElementToBeVisible(By.CssSelector("Submission"));
            TitleInput.SendKeys(Submission);


        }
        public void Category()
        {
            ClickCategoryInput.Click();
            WaitForElementToBeVisible(By.Id("0"));
            CategorylistInput.Click();
        }
        public void Savebuuton()
        {
            SaveProp.Click();
        }
        public void AssertSave()
        {
            WaitForElementToBeVisible(By.CssSelector(".v-alert"));
            // Find the alert element on the page
            IWebElement alertElement = Driver.FindElement(By.CssSelector(".v-alert"));
            // Perform an assertion to check if the alert element is displayed
            Assert.IsTrue(alertElement.Displayed, "Alert element is not displayed. Proposal request creation failed.");
        }
        public void Action()
        {
            Action0.Click();
        }
        public void EditUpdate()
        {
            Edit.Click();
        }
        public void entertitle(string title)
        {
            title = Utilities.Env.GetVariable("Title");
            WaitForElementToBeVisible(By.CssSelector("Title"));
            titleUpdate.SendKeys(title);
        }
        public void enterSubmission(string submission)
        {
            submission = Utilities.Env.GetVariable("Submission");
            WaitForElementToBeVisible(By.CssSelector("submissions"));
            submissionsUpdate.SendKeys(submission);

        }
        public void enterDeadline(string deadline)
        {
            deadline= Utilities.Env.GetVariable("Deadline");
            WaitForElementToBeVisible(By.CssSelector("Deadline"));
            submissionsUpdate.SendKeys(deadline);
        }
        public void UpdateStatus()
        {
            StatusUpdate.Click();
        }
        public void Catgoryupdate()
        {
            CategoryUpdate.Click();
            WaitForElementToBeVisible(By.Id("0"));
            CategorylistInput.Click();
        }
        public void saveUpdate()
        {
            SaveUpdate.Click();
        }
        public void DeleteProposal()
        {
            Delete.Click();
        }
        public void ConfirmDelete()
        {
            ConfirmDeleteProp.Click();
        }
        public void AssertUpdate()
        {
            WaitForElementToBeVisible(By.CssSelector(".v-alert"));
            // Find the alert element on the page
            IWebElement alertElement = Driver.FindElement(By.CssSelector(".v-alert"));
            // Perform an assertion to check if the alert element is displayed
            Assert.IsTrue(alertElement.Displayed, "Alert element is not displayed. proposal request update failed.");
        }
        public void AssertDelete()
        {
            WaitForElementToBeVisible(By.CssSelector(".v-alert"));
            // Find the alert element on the page
            IWebElement alertElement = Driver.FindElement(By.CssSelector(".v-alert"));
            // Perform an assertion to check if the alert element is displayed
            Assert.IsTrue(alertElement.Displayed, "Alert element is not displayed. proposal request Delete failed.");
        }

    }
}

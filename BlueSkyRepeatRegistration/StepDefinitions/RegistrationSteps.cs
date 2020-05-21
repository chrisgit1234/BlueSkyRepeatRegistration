using BlueSkyRepeatRegistration.PageObjects;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace BlueSkyRepeatRegistration.StepDefinitions
{
    [Binding]
    public class RegistrationSteps
    {
        RegistrationPage registrationPage;

        public RegistrationSteps()
        {
            registrationPage = new RegistrationPage();
        }

        [Given(@"I navigate to the site""(.*)""")]
        public void GivenINavigateToTheSite(string url)
        {
            registrationPage.NavigateToSite(url);
        }

        [When(@"I click on create account")]
        public void WhenIClickOnCreateAccount()
        {
            registrationPage.ClickCreatAccount();
        }

        [When(@"I click on Register")]
        public void WhenIClickOnRegister()
        {
            registrationPage.ClickRegister();
        }
        
        [When(@"i enter firt name ""(.*)""")]
        public void WhenIEnterFirtName(string first)
        {
            registrationPage.FirstName(first);
        }

        [When(@"I enter last name ""(.*)""")]
        public void WhenIEnterLastName(string last)
        {
            registrationPage.LastName(last);
        }

        [When(@"I enter email address ""(.*)""")]
        public void WhenIEnterEmailAddress(string email)
        {
            registrationPage.EmailAddress(email);
        }

        [When(@"I enter mobile number ""(.*)""")]
        public void WhenIEnterMobileNumber(string mobile)
        {
            registrationPage.EnterMobileNumber(mobile);
        }

        [When(@"i enter password ""(.*)""")]
        public void WhenIEnterPassword(string pword)
        {
            registrationPage.Password(pword);
        }

        [When(@"I eneter confirm password ""(.*)""")]
        public void WhenIEneterConfirmPassword(string cpword)
        {
            registrationPage.ConfirmPassword(cpword);
        }

        [When(@"I click on Register bottun")]
        public void WhenIClickOnRegisterBottun()
        {
            registrationPage.Registerbottun();
        }
        
        [Then(@"Message ""(.*)""")]
        public void ThenMessage(string message)
        {
            Assert.AreEqual(message, registrationPage.GetTextForSuccessMessage());
        }




















    }
}
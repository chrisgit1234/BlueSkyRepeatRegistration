using BlueSkyRepeatRegistration.Hooks;
using BlueSkyRepeatRegistration.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlueSkyRepeatRegistration.PageObjects
{
    class RegistrationPage
    {
        IWebDriver driver;
        Waits waits;

        public RegistrationPage()
        {
            driver = Hook.driver;
            waits = new Waits();

        }

        IWebElement createAccount => driver.FindElement(By.XPath("/html/body/section[1]/nav/div/div[1]/a[2]"));

        IWebElement register => driver.FindElement(By.CssSelector("#nav-register-tab"));

        IWebElement firstName => driver.FindElement(By.Id("first_name"));

        IWebElement lastName => driver.FindElement(By.Id("last_name"));

        IWebElement emailAddress => driver.FindElement(By.Id("email"));

        IWebElement enterMobileNumber => driver.FindElement(By.Id("mobile"));

        IWebElement password => driver.FindElement(By.Id("password"));

        IWebElement confirmPassword => driver.FindElement(By.Id("confirm_password"));

        IWebElement clickCaptcha => driver.FindElement(By.CssSelector("#recaptcha-anchor > div.recaptcha-checkbox-border"));

        IWebElement registerBottun => driver.FindElement(By.CssSelector("#btn_register"));

        IWebElement successMsg => driver.FindElement(By.CssSelector("#nav-signin > form > div:nth-child(3) > div > a"));

       // IWebElement generateEmail => driver.FindElement(By.Id("email")).SendKeys(genData.generateEmail(30));

       //     public string GetTitle()
       // {
       //     return driver.Title;
       // }

       
        public string GetTextForSuccessMessage()
        {
            return waits.WaitForElement(driver, successMsg).Text;
        }


        public void Registerbottun()
        {
            registerBottun.Click();
        }

        public void ClickCaptcha()
        {
           // clickCaptcha.Click();
        }

        public void Password(string pword)
        {
            password.SendKeys(pword);
        }

        public void ConfirmPassword(string cpword)
        {
            confirmPassword.SendKeys(cpword);
        }

        public void NavigateToSite(String url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void ClickCreatAccount()
        {
            createAccount.Click();
        }

        public void ClickRegister()
        {
            register.Click();

        }

        public void FirstName(string firstname)
        {
            firstName.SendKeys(firstname);
        }

        public void LastName(string lastname)
        {
            lastName.SendKeys(lastname);

        }

        public void EmailAddress(string email)
        {
            emailAddress.SendKeys(email);
        }

        public void EnterMobileNumber(string mobile)
        {
            enterMobileNumber.SendKeys(mobile);

        }
 
    }
}

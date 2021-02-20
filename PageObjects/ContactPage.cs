using JupiterToys.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;

namespace JupiterToys.PageObjects
{
    public class ContactPage : BaseClass
    {
        By btnSubmit = By.ClassName("btn-contact");
        By txtForename = By.Id("forename");
        By txtEmail = By.Id("email");
        By txtMessage = By.Id("message");
        By lblErrorHeader = By.ClassName("alert-error");
        By lblSuccessHeader = By.ClassName("alert-info");
        By lblForenameError = By.Id("forename-err");
        By lblEmailError = By.Id("email-err");
        By lblMessageError = By.Id("message-err");
        By lblSuccessMessage = By.ClassName("alert-success");

        public ContactPage(IWebDriver Driver)
        {
            driver = Driver;
        }

        public void ClickSubmit()
        {
            Click(btnSubmit);
        }

        public void EnterMandatoryFields(string data)
        {
            Clear(txtForename);
            Enter(txtForename, "Forename_" + timeStamp);
            Clear(txtMessage);
            Enter(txtMessage, "Message_" + timeStamp);
            if (data == "valid")
            {
                Clear(txtEmail);
                Enter(txtEmail, "email_" + timeStamp + "@test.com");   
            }
            else
            {
                Clear(txtEmail);
                Enter(txtEmail, "Test_email");
            }
        }

        public void VerifyValidationErrors(string errorsFor)
        {
            if (errorsFor == "email")
            {
                Assert.AreEqual("Please enter a valid email", GetText(lblEmailError));
            }
            else
            {
                Assert.AreEqual("We welcome your feedback - but we won't get it unless you complete the form correctly.", GetText(lblErrorHeader));
                Assert.AreEqual("Forename is required", GetText(lblForenameError));
                Assert.AreEqual("Email is required", GetText(lblEmailError));
                Assert.AreEqual("Message is required", GetText(lblMessageError));
            }
        }

        public void VerifyNoValidationErrors()
        {
            Assert.AreEqual("We welcome your feedback - tell it how it is.", GetText(lblSuccessHeader));
        }

        public void VerifySuccessMessage()
        {
            Assert.AreEqual("Thanks Forename_" + timeStamp + ", we appreciate your feedback.", GetText(lblSuccessMessage));
        }
    }
}

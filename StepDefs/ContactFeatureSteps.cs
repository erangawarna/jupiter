using JupiterToys.Utils;
using TechTalk.SpecFlow;

namespace JupiterToys.StepDefs
{
    [Binding]
    public class ContactFeatureSteps : BaseClass
    {
        [BeforeFeature]
        public static void AuthorizeAdminForAPI()
        {
            Setup();
        }

        [Given(@"I am in the contact page")]
        public void GivenIAmInTheContactPage()
        {
            HomePage.NavigateToHomePage();
            HomePage.NavigateToContactPage();
        }

        [When(@"I click submit button")]
        public void WhenIClickSubmitButton()
        {
            ContactPage.ClickSubmit();
        }
        
        [When(@"I populate mandtory fields with valid data")]
        public void WhenIPopulateMandtoryFieldsWithValidData()
        {
            ContactPage.EnterMandatoryFields("valid");
        }
        
        [When(@"I populate mandtory fields with invalid email")]
        public void WhenIPopulateMandtoryFieldsWithInvalidEmail()
        {
            ContactPage.EnterMandatoryFields("invalid");
        }
        
        [Then(@"I should see validation errors")]
        public void ThenIShouldSeeValidationErrors()
        {
            ContactPage.VerifyValidationErrors("all");
        }

        [Then(@"I should see validation error for invalid email")]
        public void ThenIShouldSeeValidationErrorForInvalidEmail()
        {
            ContactPage.VerifyValidationErrors("email");
        }

        [Then(@"the validation errors should go away")]
        public void ThenTheValidationErrorsShouldGoAway()
        {
            ContactPage.VerifyNoValidationErrors();
        }
        
        [Then(@"I should see the successful submission message")]
        public void ThenIShouldSeeTheSuccessfulSubmissionMessage()
        {
            ContactPage.VerifySuccessMessage();
        }

        [AfterFeature]
        public static void CloseBrowser()
        {
            Quit();
        }
    }
}

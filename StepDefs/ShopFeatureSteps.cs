using JupiterToys.Utils;
using TechTalk.SpecFlow;

namespace JupiterToys.StepDefs
{
    [Binding]
    public class ShopFeatureSteps : BaseClass
    {
        [Given(@"I am in the shop page")]
        public void GivenIAmInTheShopPage()
        {
            HomePage.NavigateToShopPage();
        }
        
        [When(@"I click buy button (.*) times on (.*)")]
        public void WhenIClickBuyButtonTimesOnFunnyCow(int times, string itemName)
        {
            ShopPage.FindAndClickBuyForItems(times, itemName);
        }
        
        [Then(@"I Click the cart menu")]
        public void ThenIClickTheCartMenu()
        {
            HomePage.NavigateToCart();
        }

        [Then(@"I can see items count in the cart matching with the added items")]
        public void ThenICanSeeItemsCountInTheCartMatchingWithTheAddedItems()
        {
            CartPage.VerifyAddedItemCount();
        }

        [Then(@"I can see (.*) items of (.*) in the cart")]
        public void ThenICanSeeItemsOfFunnyCowInTheCart(int times, string itemName)
        {
            CartPage.VerifyCartItems(times, itemName);
        }

    }
}

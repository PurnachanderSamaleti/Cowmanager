using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace Cowmanager.StepDefinitions
{
    [Binding]
    public class C_MStepDefinitions
    {
        private readonly IWebDriver driver;
        
        [Obsolete]
        public C_MStepDefinitions()
        {
            driver = ScenarioContext.Current.Get<IWebDriver>("currentDriver");
        }

        [When(@"click on CowManager logo")]
        public void WhenClickOnCowManagerLogo()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(".search-icon")));

            driver.FindElement(By.ClassName("logo")).Click();

            Assert.AreEqual(2, driver.WindowHandles.Count);
        }

        [When(@"it should be Navigate to a new tab")]
        public void WhenItShouldBeNavigateToANewTab()
        {
            driver.SwitchTo().Window(driver.WindowHandles[1]);
        }

        [When(@"enter a data on search box")]
        public void WhenEnterADataOnSearchBox()
        {
            driver.FindElement(By.Id("dnn_dnnSearch4_txtSearch")).SendKeys("Ariqt");
        }

        [Then(@"come back to parent tab")]
        public void ThenComeBackToParentTab()
        {
            driver.SwitchTo().Window(driver.WindowHandles[0]);
        }

        [When(@"entering a text data on search box")]
        public void WhenEnteringATextDataOnSearchBox()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(".search-icon")));

            driver.FindElement(By.ClassName("knowledge-base-search-box")).SendKeys("Lissette");
        }

        [When(@"click on the search button")]
        public void WhenClickOnTheSearchButton()
        {
            driver.FindElement(By.ClassName("bg-primary-red")).Click();

            Assert.AreEqual(2, driver.WindowHandles.Count);
        }

        [When(@"it should navigate to a new tab")]
        public void WhenItShouldNavigateToANewTab()
        {
            driver.SwitchTo().Window(driver.WindowHandles[1]);
        }

        [When(@"click on the Language button")]
        public void WhenClickOnTheLanguageButton()
        {
            driver.FindElement(By.Id("14")).Click();
        }

        [Then(@"come back parent tab")]
        public void ThenComeBackParentTab()
        {
            driver.SwitchTo().Window(driver.WindowHandles[0]);
        }

        [When(@"click on support community")]
        public void WhenClickOnSupportCommunity()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(".search-icon")));

            driver.FindElement(By.ClassName("bottom-buttons")).Click();

            Assert.AreEqual(2, driver.WindowHandles.Count);
        }

        [When(@"it should navigate a new tab")]
        public void WhenItShouldNavigateANewTab()
        {
            driver.SwitchTo().Window(driver.WindowHandles[1]);
        }

        [When(@"click on the trending topiics")]
        public void WhenClickOnTheTrendingTopiics()
        {
            driver.FindElement(By.XPath("//*[contains(text(),'Trending topics')]")).Click();
        }

        [Then(@"it should come back to parent tab")]
        public void ThenItShouldComeBackToParentTab()
        {
            driver.SwitchTo().Window(driver.WindowHandles[0]);
        }

        [When(@"click on userfield it should show the logout change password buttons")]
        public void WhenClickOnUserfieldItShouldShowTheLogoutChangePasswordButtons()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(".search-icon")));

            driver.FindElement(By.Id("accountMenuDropdownToggle")).Click();
        }

        [When(@"click on change password button it should navigate to a new page and ask enter old password")]
        public void WhenClickOnChangePasswordButtonItShouldNavigateToANewPageAndAskEnterOldPassword()
        {
            driver.FindElement(By.LinkText("Change password")).Click();
        }

        [When(@"enter old password")]
        public void WhenEnterOldPassword()
        {
            driver.FindElement(By.Id("oldPassword")).Click();

            driver.FindElement(By.Id("oldPassword")).SendKeys("Ariqt@321");
        }

        [When(@"enter the new password")]
        public void WhenEnterTheNewPassword()
        {
            driver.FindElement(By.Id("newPassword")).Click();

            driver.FindElement(By.Id("newPassword")).SendKeys("Ariqt@123");
        }

        [When(@"enter the confirm password")]
        public void WhenEnterTheConfirmPassword()
        {
            driver.FindElement(By.Id("reenterPassword")).Click();

            driver.FindElement(By.Id("reenterPassword")).SendKeys("Ariqt@123");
        }

        [Then(@"click on continue button it should navigate into the application")]
        public void ThenClickOnContinueButtonItShouldNavigateIntoTheApplication()
        {
            driver.FindElement(By.Id("continue")).Click();
        }

        [When(@"click on userfield it shows logout and change password")]
        public void WhenClickOnUserfieldItShowsLogoutAndChangePassword()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(".search-icon")));

            driver.FindElement(By.Id("accountMenuDropdownToggle")).Click();
        }

        [When(@"click the logout button")]
        public void WhenClickTheLogoutButton()
        {
            driver.FindElement(By.LinkText("Logout")).Click();
        }

        [Then(@"it should navigate to the login page and shows welcome back")]
        public void ThenItShouldNavigateToTheLoginPageAndShowsWelcomeBack()
        {
            driver.FindElement(By.Id("signInName")).SendKeys("Welcome back");
        }



        [Given(@"Enter a valid username")]
        public void GivenEnterAValidUsername()
        {
            driver.FindElement(By.Name("Username / E-Mail")).SendKeys("ariqt1");
        }

        [When(@"enter a valid password")]
        public void WhenEnterAValidPassword()
        {
            driver.FindElement(By.Id("password")).Click();

            driver.FindElement(By.Id("password")).SendKeys("Ariqt@123");
        }

        [When(@"click on keep me sign in button then it should not ask next time for re-login")]
        public void WhenClickOnKeepMeSignInButtonThenItShouldNotAskNextTimeForRe_Login()
        {
            driver.FindElement(By.Id("rememberMe")).Click();
        }

        [Then(@"click on Sign in button")]
        public void ThenClickOnSignInButton()
        {
            driver.FindElement(By.Id("next")).Click();
        }

        [When(@"click on input button it displays input sub items")]
        public void WhenClickOnInputButtonItDisplaysInputSubItems()
        {
            driver.FindElement(By.LinkText("Input")).Click();
        }

        [Then(@"click again input button now it should hide the input sub items")]
        public void ThenClickAgainInputButtonNowItShouldHideTheInputSubItems()
        {
            driver.FindElement(By.LinkText("Input")).Click();
        }

        [When(@"click on nutrition button it should display the nutrition sub items")]
        public void WhenClickOnNutritionButtonItShouldDisplayTheNutritionSubItems()
        {
            driver.FindElement(By.LinkText("Nutrition")).Click();
        }

        [Then(@"click again nutrition button now it should hide the nutrition sub items")]
        public void ThenClickAgainNutritionButtonNowItShouldHideTheNutritionSubItems()
        {
            driver.FindElement(By.LinkText("Nutrition")).Click();
        }

        [When(@"click on find my cow it should display the find my cow sub items")]
        public void WhenClickOnFindMyCowItShouldDisplayTheFindMyCowSubItems()
        {
            driver.FindElement(By.LinkText("Find my Cow")).Click();
        }

        [Then(@"click again on find my cow now it should hide the find my cow sub items")]
        public void ThenClickAgainOnFindMyCowNowItShouldHideTheFindMyCowSubItems()
        {
            driver.FindElement(By.LinkText("Find my Cow")).Click();
        }

        [When(@"click on settings it should open the setings sub items")]
        public void WhenClickOnSettingsItShouldOpenTheSetingsSubItems()
        {
            driver.FindElement(By.LinkText("Settings")).Click();
        }

        [Then(@"click again on settings button now it should hide the settings sub items")]
        public void ThenClickAgainOnSettingsButtonNowItShouldHideTheSettingsSubItems()
        {
            driver.FindElement(By.LinkText("Settings")).Click();
        }

        [When(@"click on system status it should open the sub items of system status")]
        public void WhenClickOnSystemStatusItShouldOpenTheSubItemsOfSystemStatus()
        {
            driver.FindElement(By.LinkText("System status")).Click();
        }

        [Then(@"click again on system status now it should hide the sub items of system status")]
        public void ThenClickAgainOnSystemStatusNowItShouldHideTheSubItemsOfSystemStatus()
        {
            driver.FindElement(By.LinkText("System status")).Click();
        }

        [When(@"click on membership button it should open the membership sub item")]
        public void WhenClickOnMembershipButtonItShouldOpenTheMembershipSubItem()
        {
            driver.FindElement(By.LinkText("Membership")).Click();
        }

        [Then(@"click again on membership button now it should hide the sub item of membership button")]
        public void ThenClickAgainOnMembershipButtonNowItShouldHideTheSubItemOfMembershipButton()
        {
            driver.FindElement(By.LinkText("Membership")).Click();
        }

        [When(@"click on deleted functionality it should shows only deleted companies list")]
        public void WhenClickOnDeletedFunctionalityItShouldShowsOnlyDeletedCompaniesList()
        {
            driver.FindElement(By.PartialLinkText("custom-control-label")).Click();
        }

        [Then(@"click on show only network issues it should shows only network issues company list from deleted companies")]
        public void ThenClickOnShowOnlyNetworkIssuesItShouldShowsOnlyNetworkIssuesCompanyListFromDeletedCompanies()
        {
            driver.FindElement(By.LinkText("Show only network issues")).Click();
        }

        [When(@"click on active button it should shows only active companies list")]
        public void WhenClickOnActiveButtonItShouldShowsOnlyActiveCompaniesList()
        {
            driver.FindElement(By.LinkText("Active")).Click();
        }

        [Then(@"click on show only network issues it should shows only network issues companies list from the active companies")]
        public void ThenClickOnShowOnlyNetworkIssuesItShouldShowsOnlyNetworkIssuesCompaniesListFromTheActiveCompanies()
        {
            driver.FindElement(By.LinkText("Show only network issues")).Click();
        }

    }
}

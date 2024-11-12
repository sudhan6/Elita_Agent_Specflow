using OpenQA.Selenium;
using TechTalk.SpecFlow;

[Binding]
public class LoginSteps
{
    private IWebDriver driver;
    private LoginPageActions loginPageActions;

    public LoginSteps(IWebDriver driver)
    {
        this.driver = driver;
        loginPageActions = new LoginPageActions(driver);
    }

    [Given("I am on the login page")]
    public void GivenIAmOnTheLoginPage()
    {
        driver.Navigate().GoToUrl("https://example.com/login");
    }

    [When("I enter '(.*)' and '(.*)'")]
    public void WhenIEnterUsernameAndPassword(string username, string password)
    {
        loginPageActions.EnterUsername(username);
        loginPageActions.EnterPassword(password);
    }

    [And("I click the login button")]
    public void AndIClickTheLoginButton()
    {
        loginPageActions.ClickLoginButton();
    }

    [Then("I should be redirected to the product page")]
    public void ThenIShouldBeRedirectedToTheProductPage()
    {
        bool isLoginSuccessful = loginPageActions.IsLoginSuccessful();
        Assert.IsTrue(isLoginSuccessful, "Login was not successful.");
    }

    [And("I logout")]
    public void AndILogout()
    {
        // Implement logout functionality
    }
}
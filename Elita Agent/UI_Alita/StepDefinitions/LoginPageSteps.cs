using TechTalk.SpecFlow;

[Binding]
public class LoginPageSteps
{
    private LoginPageActions loginPageActions;

    public LoginPageSteps()
    {
        loginPageActions = new LoginPageActions(Hooks.WebDriver);
    }

    [Given("the user is on the Login Page")]
    public void GivenTheUserIsOnTheLoginPage()
    {
        // Navigate to the login page
    }

    [When("the user enters valid username and password")]
    public void WhenTheUserEntersValidUsernameAndPassword()
    {
        loginPageActions.EnterUsername("validUser");
        loginPageActions.EnterPassword("validPass");
    }

    [When("the user enters an invalid username or password")]
    public void WhenTheUserEntersAnInvalidUsernameOrPassword()
    {
        loginPageActions.EnterUsername("invalidUser");
        loginPageActions.EnterPassword("invalidPass");
    }

    [When("the user clicks on the login button")]
    public void WhenTheUserClicksOnTheLoginButton()
    {
        loginPageActions.ClickLoginButton();
    }

    [Then("the user is redirected to the Home Page")]
    public void ThenTheUserIsRedirectedToTheHomePage()
    {
        // Assert that the user is on the home page
    }

    [Then("an error message 'invalid credentials' is displayed")]
    public void ThenAnErrorMessageInvalidCredentialsIsDisplayed()
    {
        // Assert that the error message is displayed
    }
}
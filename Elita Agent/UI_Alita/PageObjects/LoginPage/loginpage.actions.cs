using OpenQA.Selenium;

public class LoginPageActions
{
    private IWebDriver driver;
    private SeleniumMethods seleniumMethods;

    public LoginPageActions(IWebDriver driver)
    {
        this.driver = driver;
        seleniumMethods = new SeleniumMethods();
    }

    public void EnterUsername(string username)
    {
        seleniumMethods.SendKeys(driver.FindElement(LoginPageLocators.UsernameField), username);
    }

    public void EnterPassword(string password)
    {
        seleniumMethods.SendKeys(driver.FindElement(LoginPageLocators.PasswordField), password);
    }

    public void ClickLoginButton()
    {
        seleniumMethods.Click(driver.FindElement(LoginPageLocators.LoginButton));
    }

    public bool IsLoginSuccessful()
    {
        // This method would typically check for elements that are only visible upon successful login
        return seleniumHelpers.IsElementPresent(By.Id("product-page-element"));
    }
}
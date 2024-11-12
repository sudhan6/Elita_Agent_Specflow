using OpenQA.Selenium;

public static class LoginPageLocators
{
    public static readonly By UsernameField = By.Id("user-name");
    public static readonly By PasswordField = By.Id("password");
    public static readonly By LoginButton = By.Id("login-button");
}
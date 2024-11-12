using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

public class SeleniumHelpers
{
    private IWebDriver driver;
    public SeleniumHelpers(IWebDriver driver)
    {
        this.driver = driver;
    }

    public void SendKeys(By locator, string text)
    {
        var element = driver.FindElement(locator);
        element.Clear();
        element.SendKeys(text);
    }

    public void Click(By locator)
    {
        var element = driver.FindElement(locator);
        element.Click();
    }

    public bool IsElementPresent(By locator)
    {
        try
        {
            driver.FindElement(locator);
            return true;
        }
        catch (NoSuchElementException)
        {
            return false;
        }
    }

    public void WaitForElementVisible(By locator, int timeoutInSeconds)
    {
        if (timeoutInSeconds > 0)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.VisibilityOfAllElementsLocatedBy(locator));
        }
    }

    // Additional methods can be implemented as needed
}
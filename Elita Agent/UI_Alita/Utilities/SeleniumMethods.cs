// Selenium Methods for Automation Framework

public class SeleniumMethods
{
    public void SendKeys(IWebElement element, string value)
    {
        element.SendKeys(value);
    }

    public void Click(IWebElement element)
    {
        element.Click();
    }

    public string GetText(IWebElement element)
    {
        return element.Text;
    }

    // Add more methods as required for the framework

    public void SwitchToWindow(string windowHandle)
    {
        Driver.SwitchTo().Window(windowHandle);
    }

    public void WaitForElementVisible(IWebElement element, int timeoutInSeconds)
    {
        WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(timeoutInSeconds));
        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(element));
    }

    public void SelectDropDown(IWebElement element, string value)
    {
        SelectElement select = new SelectElement(element);
        select.SelectByValue(value);
    }

    public void AcceptAlert()
    {
        Driver.SwitchTo().Alert().Accept();
    }

    public void TakeScreenshot(string filename)
    {
        Screenshot screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
        screenshot.SaveAsFile(filename, ScreenshotImageFormat.Png);
    }

    public void MoveToElementAndClick(IWebElement element)
    {
        Actions actions = new Actions(Driver);
        actions.MoveToElement(element).Click().Perform();
    }
}
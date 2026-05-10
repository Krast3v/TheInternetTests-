using OpenQA.Selenium;

namespace TheInternetTests.Pages;

public class MultipleWindowsPage
{
    private readonly IWebDriver driver;

    public MultipleWindowsPage(IWebDriver driver)
    {
        this.driver = driver;
    }

    public void Open()
    {
        driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/windows");
    }

    public void ClickOpenNewWindow()
    {
        driver.FindElement(By.LinkText("Click Here")).Click();
    }

    public void SwitchToNewWindow()
    {
        string newWindow = driver.WindowHandles.Last();
        driver.SwitchTo().Window(newWindow);
    }

    public void SwitchToMainWindow()
    {
        string mainWindow = driver.WindowHandles.First();
        driver.SwitchTo().Window(mainWindow);
    }

    public string GetTitle()
    {
        return driver.Title;
    }

    public int GetWindowCount()
    {
        return driver.WindowHandles.Count;
    }
}

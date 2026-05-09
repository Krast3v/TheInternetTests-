using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TheInternetTests.Pages;

namespace TheInternetTests;

[TestFixture]
public class DynamicLoadingTests
{
    private IWebDriver driver;
    private DynamicLoadingPage page;

    [SetUp]
    public void Setup()
    {
        driver = new ChromeDriver();
        page = new DynamicLoadingPage(driver);
    }

    [Test]
    public void Example1ShowsHelloWorldAfterLoad()
    {
        page.Open(1);
        page.ClickStart();
        Assert.That(page.GetFinishText(), Is.EqualTo("Hello World!"));
    }

    [Test]
    public void Example2ShowsHelloWorldAfterLoad()
    {
        page.Open(2);
        page.ClickStart();
        Assert.That(page.GetFinishText(), Is.EqualTo("Hello World!"));
    }

    [TearDown]
    public void TearDown()
    {
        driver.Quit();
        driver.Dispose();
    }
}

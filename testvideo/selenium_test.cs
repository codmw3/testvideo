using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Firefox;
using Xunit;

public class SearchTests
{
string driverPath = @"C:\Users\Arslana\Desktop\testvideo\chromedriver.exe";

    
    private readonly IWebDriver _driver;

    public SearchTests()
    {
        // Create a new Chrome driver
        _driver = new ChromeDriver();

        // Alternatively, create a new Firefox driver
        // _driver = new FirefoxDriver();
    }

    [Fact]
    public void SearchTest()
    {
        // Navigate to the search page
        _driver.Navigate().GoToUrl("https://testvideoapp.azurewebsites.net/");

        // Find the search box and enter a query
        var searchInput = _driver.FindElement(By.Id("search-input"));
        searchInput.SendKeys("test query");

        // Find the search button and click it
        var searchButton = _driver.FindElement(By.Id("search-button"));
        searchButton.Click();

        // Assert that the search results page is displayed
        var pageTitle = _driver.Title;
        Assert.Equal("Search Results - Your App Name", pageTitle);
    }

    public void Dispose()
    {
        // Quit the driver and release all associated resources
        _driver.Quit();
        _driver.Dispose();
    }
}

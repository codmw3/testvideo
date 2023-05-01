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


           // Navigate to the search page
    _driver.Navigate().GoToUrl("https://testvideoapp.azurewebsites.net/");

       // Find the search box and search button
    var searchInput = _driver.FindElement(By.Id("search-input"));
    var searchButton = _driver.FindElement(By.Id("search-button"));

    // Click the search button without entering any text in the search box
    searchButton.Click();

    // Check if an error message is displayed
    var errorMessage = _driver.FindElement(By.Id("error-message"));
    Assert.Equal("Please enter a search query", errorMessage.Text);

    // Enter a query in the search box
    searchInput.SendKeys("test query");

// Click the search button again
    searchButton.Click();

    // Assert that the search results page is displayed
    var pageTitle = _driver.Title;
    Assert.Equal("Search Results - Your App Name", pageTitle);
}


}

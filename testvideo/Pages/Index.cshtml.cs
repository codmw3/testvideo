using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Firefox;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace testvideo.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}


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

//     [Fact]
//     public void SearchTest()
//     {
//         // Navigate to the search page


//            // Navigate to the search page
//     _driver.Navigate().GoToUrl("https://testvideoapp.azurewebsites.net/");

//        // Find the search box and search button
//     var searchInput = _driver.FindElement(By.Id("search-input"));
//     var searchButton = _driver.FindElement(By.Id("search-button"));

//     // Click the search button without entering any text in the search box
//     searchButton.Click();

//     // Check if an error message is displayed
//     var errorMessage = _driver.FindElement(By.Id("error-message"));
//     Assert.Equal("Please enter a search query", errorMessage.Text);

//     // Enter a query in the search box
//     searchInput.SendKeys("test query");

// // Click the search button again
//     searchButton.Click();

//     // Assert that the search results page is displayed
//     var pageTitle = _driver.Title;
//     Assert.Equal("Search Results - Your App Name", pageTitle);
// }


// [Fact]
// public void SearchTest()
// {
//            //Navigate to the search page
//     _driver.Navigate().GoToUrl("https://testvideoapp.azurewebsites.net/");

//     // Find the search box and search button
//     var searchInput = _driver.FindElement(By.Id("search-input"));
//     var searchButton = _driver.FindElement(By.Id("search-button"));

//     // Click the search button without entering any text in the search box
//     searchButton.Click();

//     // Check if the URL contains the search page URL pattern (e.g. /search)
//     var url = _driver.Url;
//     Assert.Contains("/search", url);

//     // Enter a query in the search box
//     searchInput.SendKeys("test query");

//     // Click the search button again
//     searchButton.Click();

//     // Assert that the search results page is displayed
//     url = _driver.Url;
//     Assert.Contains("/search-results", url);
// }

[Fact]
public void SearchTest()
{
    // Navigate to the search page
    _driver.Navigate().GoToUrl("https://testvideoapp.azurewebsites.net/");

    // Find the search box and search button
    var searchInput = _driver.FindElement(By.Id("search-input"));
    var searchButton = _driver.FindElement(By.Id("search-button"));

    // Click the search button without entering any text in the search box
    searchButton.Click();

    // Check if an error message is displayed
    var errorMessage = _driver.FindElement(By.Id("error-message"));
    if (errorMessage != null && errorMessage.Displayed)
    {
        // Generate a browser alert
        var alert = _driver.SwitchTo().Alert();
        Assert.Equal("Please enter a search query", alert.Text);
        alert.Accept();
    }

    // Enter a query in the search box
    searchInput.SendKeys("test query");

    // Click the search button again
    searchButton.Click();

    // Assert that the search results page is displayed
    var pageTitle = _driver.Title;
    Assert.Equal("Search Results - Your App Name", pageTitle);
}


}

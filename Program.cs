using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using BingRewardsAutoSearcher;
using System.Security.Cryptography;

// Modify this if you need to use a specific Edge profile.
var profileName = "Default";

// Modify this to change the number of searches that will occur. Should not exceed the number of available search phrases.
var searchCount = 30;

Console.WriteLine("Opening Browser");

// Set up browser and open it.
var options = new EdgeOptions();

// Set desired profile.
var edgeUserDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Microsoft\\Edge\\User Data";
options.AddArgument("user-data-dir=" + edgeUserDataPath);
Console.WriteLine(edgeUserDataPath);
options.AddArgument("profile-directory=" + profileName);
options.AddArgument("--remote-debugging-port=9222");

// Open browser.
IWebDriver driver = new EdgeDriver(options);

Console.WriteLine("Navigating to Bing");

// Navigate to Bing
driver.Navigate().GoToUrl("https://www.bing.com/");

var searchPhrases = SearchPhrases.GetRandom(30);

// Iterate through the number of shuffled search phrases specified above.
for (int i = 0; i < searchCount; i++)
{
    // Locate the search box, input the search phrase, and submit.
    var searchBox = driver.FindElement(By.Id("sb_form_q"));

    searchBox.Clear();
    searchBox.SendKeys(searchPhrases[i]);
    searchBox.SendKeys(Keys.Enter);

    Thread.Sleep(6000);
}

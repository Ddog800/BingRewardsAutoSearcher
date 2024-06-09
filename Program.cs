using OpenQA.Selenium.Edge;
using OpenQA.Selenium;

// Modify this if you need to use a specific Edge profile.
var profileName = "Default";

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
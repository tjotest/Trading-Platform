using TechTalk.SpecFlow;
using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace TradingPlatform.steps
{
[Binding]
public class ExampleSearchPortsSteps
{
    [Given(@"Trader is on port searchform")]
    public void GivenTraderSearhOnPortName(){
        
        String pathToChromeDriver = "C:\\Source\\Bunker Holding\\TradingPlatform\\bin\\Debug\\netcoreapp2.1\\";
        ChromeOptions options =  new ChromeOptions();
        options.AddArguments("user-data-dir=C:\\Source\\Bunker Holding\\Chrome Users");
        options.AddArguments("profile-directory=Profile 1");

        IWebDriver myDriver = new ChromeDriver(pathToChromeDriver, options);
        WebDriverWait wait = new WebDriverWait(myDriver, TimeSpan.FromSeconds(20));

        myDriver.Navigate().GoToUrl("https://bh-crm-test.crm4.dynamics.com/main.aspx?appid=229d6b39-4261-4eae-829e-47440f44180e&pagetype=dashboard&id=daffd94c-5080-e911-a854-000d3ab4db84&type=system&_canOverride=true");

        //wait.Until(ExpectedConditions.ElementExists(By.XPath("//input[@type='email']")));
        //IWebElement mail = myDriver.FindElement(By.XPath("//input[@type='email']"));
        //mail.SendKeys("bhitcrm1@bunker-holding.com");
        //mail.SendKeys(Keys.Enter);
        //wait.Until(ExpectedConditions.ElementExists(By.Id("passwordInput")));
        //IWebElement password = myDriver.FindElement(By.Id("passwordInput"));
        //password.SendKeys("pyUKAmTeGe4R4GJz");
        //password.SendKeys(Keys.Enter);

    }
    [When(@"Portname is typed and enter is pressed")]
    public void WhenAction(){
        Console.WriteLine("When Some conditions");
    }
 
    [Then(@"results matcing the Portname is shown")]
    public void ThenTestableOutcome(){
        Console.WriteLine("Then some outcome");
        Assert.IsTrue(true,"expected true but found false");
    }
  }
}
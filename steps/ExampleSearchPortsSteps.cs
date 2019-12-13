using TechTalk.SpecFlow;
using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace TradingPlatform.steps
{
[Binding]
public class ExampleSearchPortsSteps
{   
    [Given(@"Trader is on port searchform")]
    public void GivenTraderSearhOnPortName(){
        
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
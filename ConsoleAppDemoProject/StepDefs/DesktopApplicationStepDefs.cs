using System;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using TechTalk.SpecFlow;

namespace ConsoleAppDemoProject.StepDefs
{
    [Binding]
    public sealed class DesktopApplicationStepDefs
    {
        private const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723/";
        private const string LaunchApp = @"G:\POC Folder\AutomationProject\AutomationProject\bin\Debug\AutomationProject.exe";

        public static WindowsDriver<WindowsElement> driver = null;

        [Given(@"I have launched the application")]
        public void GivenIHaveLaunchedTheApplication()
        {
            AppiumOptions opt = new AppiumOptions();
            opt.AddAdditionalCapability("app", LaunchApp);
            opt.AddAdditionalCapability("deviceName", "WindowsPC");
            driver = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), opt);

           /* var htmlReporter = new ExtentHtmlReporter(@"C:\Users\hp\source\repos\ConsoleAppDemoProject\ConsoleAppDemoProject\ExtentReport.html");
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;

            var extent = new ExtentReports();

            extent.AttachReporter(htmlReporter);

            //Feature
            var feature = extent.CreateTest<Feature>("DemoProject");

            //Scenario
            var scenario = feature.CreateNode<Scenario>("Login User as Administrator");

            //Steps
            scenario.CreateNode<Given>("I have launched the application");

            extent.Flush();*/
            //ScenarioContext.Current.Pending();
        }

        [When(@"I have entered username ""(.*)"" and password ""(.*)""")]
        public void GivenIHaveEnteredUsernameAndPassword(string username, string password)
        {
            driver.FindElementByAccessibilityId("txtLogin").SendKeys(username);
            driver.FindElementByAccessibilityId("txtPassword").SendKeys(password);
            //ScenarioContext.Current.Pending();
        }

        [Then(@"i click to login button")]
        public void GivenIClickToLoginButton()
        {
            driver.FindElementByAccessibilityId("btnLogin").Click();
            //driver.FindElementByAccessibilityId("btnStart").Click();

           /* Assert.Multiple(() =>
            {*/
                Assert.That("Start ", Is.EqualTo("Start Process"), "text does bnot match");
               // Assert.That("hi", Is.Not.Null, "good");
            /*});*/


            //ScenarioContext.Current.Pending();
        }
    }
}

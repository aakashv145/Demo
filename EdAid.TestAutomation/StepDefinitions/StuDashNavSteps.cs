using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace EdAid.TestAutomation.StepDefinitions
{
    [Binding]
    public sealed class StuDashNavSteps : LamdaTestStep
    {
            public StuDashNavSteps(ScenarioContext ScenarioContext) : base(ScenarioContext)
            {
            }

            String test_url = "https://www.uat.edaid.com";


        [Then(@"I can see Funding information")]
        public void ThenICanSeeFundingInformation()
        {
           //Total Deferred
            IWebElement total = LTDriver.WebDriver.FindElement(By.CssSelector("#homepage-container > div > div > div:nth-child(1) > div > table > tbody > tr:nth-child(1) > td:nth-child(1) > p:nth-child(1)"));
            Assert.That(total.Text == ("Total Deferred"));
            Console.WriteLine("Total Deferred");
            //Paid To Date
            IWebElement paidTD = LTDriver.WebDriver.FindElement(By.CssSelector("#homepage-container > div > div > div:nth-child(1) > div > table > tbody > tr:nth-child(2) > td:nth-child(1) > p:nth-child(1)"));
            Assert.That(paidTD.Text == ("Paid To Date"));
            Console.WriteLine("Paid To Date");
            //Balance
            IWebElement balance = LTDriver.WebDriver.FindElement(By.CssSelector("#homepage-container > div > div > div:nth-child(1) > div > table > tbody > tr:nth-child(3) > td:nth-child(1) > p:nth-child(1)"));
            Assert.That(balance.Text == ("Balance"));
            Console.WriteLine("Balance");
            //Last Payment
            IWebElement lastPay= LTDriver.WebDriver.FindElement(By.CssSelector("#homepage-container > div > div > div:nth-child(1) > div > table > tbody > tr:nth-child(4) > td:nth-child(1) > p:nth-child(1)"));
            Assert.That(lastPay.Text == ("Last Payment"));
            Console.WriteLine("Last Payment");
            //Next Payment Amount
            IWebElement nextPay = LTDriver.WebDriver.FindElement(By.CssSelector("#homepage-container > div > div > div:nth-child(1) > div > table > tbody > tr:nth-child(5) > td:nth-child(1) > p:nth-child(1)"));
            Assert.That(nextPay.Text == ("Next Monthly Payment Amount"));
            Console.WriteLine("Next Payment Amount");
            //Next Monthly Payment Date
            IWebElement nextPayDate = LTDriver.WebDriver.FindElement(By.CssSelector("#homepage-container > div > div > div:nth-child(1) > div > table > tbody > tr:nth-child(6) > td:nth-child(1) > p:nth-child(1)"));
            Assert.That(nextPayDate.Text == ("Next Monthly Payment Date"));
            Console.WriteLine("Next Monthly Payment Date");
            //Payment Countdown
            IWebElement countdown = LTDriver.WebDriver.FindElement(By.CssSelector("#homepage-container > div > div > div:nth-child(1) > div > table > tbody > tr:nth-child(7) > td:nth-child(1) > p:nth-child(1)"));
            Assert.That(countdown.Text == ("Payment Countdown"));
            Console.WriteLine("Payment Countdown");
            //Final payment
            IWebElement finalPayment = LTDriver.WebDriver.FindElement(By.CssSelector("#homepage-container > div > div > div:nth-child(1) > div > table > tbody > tr:nth-child(8) > td:nth-child(1) > p:nth-child(1)"));
            Assert.That(finalPayment.Text == ("Your final payment will be in"));
            Console.WriteLine("Final Payment");
            //View Agreement
            IWebElement viewAgreement = LTDriver.WebDriver.FindElement(By.CssSelector("#homepage-container > div > div > div:nth-child(1) > div > div > a"));
            Assert.That(viewAgreement.Text == ("VIEW AGREEMENT"));
            Console.WriteLine("View Agreement");
            //Payment Schedule
            IWebElement paySched = LTDriver.WebDriver.FindElement(By.CssSelector("#homepage-container > div > div > div:nth-child(3) > div > h4"));
            Assert.That(paySched.Text == ("Payment Schedule"));
            Console.WriteLine("Payment Schedule");
            //Billing History
            IWebElement billHist= LTDriver.WebDriver.FindElement(By.CssSelector("#homepage-container > div > div > div:nth-child(4) > div > h4"));
            Assert.That(billHist.Text == ("Billing History"));
            Console.WriteLine("Billing History");

        }

        [Then(@"I can see Payment Method information")]
        public void ThenICanSeePaymentMethodInformation()
        {
            //Payment Method
            IWebElement payMethod = LTDriver.WebDriver.FindElement(By.CssSelector("#homepage-container > div > div > div:nth-child(2) > div > section > div > section:nth-child(1) > div > h4"));
            Assert.That(payMethod.Text == ("Payment Method"));
            Console.WriteLine("Payment Method");
            //Switch Payment Method
            IWebElement switchMethod = LTDriver.WebDriver.FindElement(By.CssSelector("#homepage-container > div > div > div:nth-child(2) > div > section > div > section:nth-child(1) > div > section > div > div.col-xs-12.padding-0 > div > button"));
            Assert.That(switchMethod.Text == ("SWITCH PAYMENT ACCOUNT"));
            Console.WriteLine(" Switch Payment Account ");
            //Additional Payment
            IWebElement addPay = LTDriver.WebDriver.FindElement(By.CssSelector("#homepage-container > div > div > div:nth-child(5) > div > h4"));
            Assert.That(addPay.Text == ("Additional Payments"));
            Console.WriteLine("Additional Payments");
            //Schedule an additional payment
            IWebElement schedPay = LTDriver.WebDriver.FindElement(By.CssSelector("#homepage-container > div > div > div:nth-child(5) > div > div > div:nth-child(2) > div.mar-b-20.mar-t-10.text-center > button"));
            Assert.That(schedPay.Text == ("SCHEDULE AN ADDITIONAL PAYMENT"));
            Console.WriteLine("Schedule an additional payment");

            Thread.Sleep(2000);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;

namespace SeleniumTests
{
    [TestFixture]
    class SeleniumFirst
    {
        [Test]
        public void FirstTest()
        {
            Console.WriteLine("FirstTest1() ThreadID= " + Thread.CurrentThread.ManagedThreadId);

            //можемо ініціалізувати різні браузери
            //IWebDriver driver = new FirefoxDriver();
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("http://demo.opencart.com/");
         
            driver.FindElement(By.CssSelector("#search > input")).Click();

            #region Lasyinitialisation
            // ---- Lasy initialisation -----
            //var SearchField = driver.FindElement(By.CssSelector("#search > input"));

            //driver.Navigate().Refresh();

            //SearchField.Clear();
            //SearchField.SendKeys("iPhone" + Keys.Enter);

            #endregion Lasyinitialisation

            driver.FindElement(By.CssSelector("#search > input")).Clear();

            driver.FindElement(By.CssSelector("#search > input")).SendKeys("iPhone" + Keys.Enter);

            //driver.FindElement(By.Id("lst-ib")).SendKeys("selenium ide" + Keys.Enter);
            //driver.FindElement(By.CssSelector("#search > input")).SendKeys("iPhone");
            //driver.FindElement(By.CssSelector("#search > input")).Submit();
            Thread.Sleep(2000);

            #region JavaScriptExecutor
            //-----------------------JavaScriptExecutor--------------------------------------------
            IJavaScriptExecutor javaScript = (IJavaScriptExecutor)driver;
            javaScript.ExecuteScript("alert('Hello!');");
            Thread.Sleep(3000);
            driver.SwitchTo().Alert().Accept();

                   
            //----Search By JavaScript
            //IJavaScriptExecutor javaScript = (IJavaScriptExecutor)driver;
            IWebElement actual = (IWebElement)javaScript
                .ExecuteScript("return document.getElementsByClassName('caption')[0];", new object[1] { "" });


            //----Goto Position By JavaScript.
            //IJavaScriptExecutor javaScript = (IJavaScriptExecutor)driver;
            //IWebElement position = driver.FindElement(By.CssSelector("body > footer > div > p > a"));
            //javaScript.ExecuteScript("arguments[0].scrollIntoView(true);", position);

            //Thread.Sleep(4000);
            #endregion JavaScriptExecutor

            // Goto Position. Use Actions class
            Actions action = new Actions(driver);

            IWebElement position = driver.FindElement(By.CssSelector("body > footer > div > p > a"));

            action.MoveToElement(position).Perform();
            action.ClickAndHold().MoveToElement(position).Perform();

            //Thread.Sleep(4000);

            Assert.True(actual.Text.Contains("iPhone"));

            ITakesScreenshot takesScreenshot = driver as ITakesScreenshot;
            Screenshot screenshot = takesScreenshot.GetScreenshot();
            screenshot.SaveAsFile("c:/Screenshot1.png", ScreenshotImageFormat.Png);
         
            driver.Quit();
        }

        [Test]
        public void TestDragDrop()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://mdn.github.io/dom-examples/drag-and-drop/copy-move-DataTransfer.html");

            //   Assert.True(driver.FindElement(By.Id("newId")).Displayed);

            IWebElement source = driver.FindElement(By.Id("src_copy"));
            IWebElement target = driver.FindElement(By.Id("dest_copy"));

            Actions builder = new Actions(driver);
            builder.DragAndDrop(source, target).Perform();

            Thread.Sleep(3000);
            try
            {
                Assert.True(driver.FindElement(By.Id("newId")).Displayed);
                Thread.Sleep(3000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            ITakesScreenshot takesScreenshot = driver as ITakesScreenshot;
            Screenshot screenshot = takesScreenshot.GetScreenshot();
            screenshot.SaveAsFile("c:/Screenshot1.png", ScreenshotImageFormat.Png);

            driver.Quit();
        }


      //  [Test]
        public void TestDragDrop2()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--start-maximized");
            options.AddArguments("--no-proxy-server");
            //options.AddArguments("--no-sandbox");
            //options.AddArguments("--disable-web-security");
            options.AddArguments("--ignore-certificate-errors");
            //options.AddArguments("--disable-extensions");
            //options.AddArguments("--headless");
            IWebDriver driver = new ChromeDriver(options);


            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/drag_and_drop");

            Thread.Sleep(3000);


            WebElement source = (WebElement)driver.FindElement(By.Id("column-a"));
            WebElement target = (WebElement)driver.FindElement(By.Id("column-b"));

            Assert.True(source.Text == "A");

            Actions builder = new Actions(driver);

            //     builder.ClickAndHold(source).MoveToElement(target).Click(target).Release(target).Build().Perform();

            //builder.ClickAndHold(source).Build().Perform();
            //Thread.Sleep(2000);
            //builder.Click(target).Build().Perform();
            //builder.Release(target).Build().Perform();


            builder.DragAndDropToOffset(source, 200, 400).Perform();

            //     builder.ClickAndHold(source).Release(target).Build().Perform();

            target.Click();

            Thread.Sleep(3000);

            Assert.True(target.Text == "A");


            //ITakesScreenshot takesScreenshot = driver as ITakesScreenshot;
            //Screenshot screenshot = takesScreenshot.GetScreenshot();
            //screenshot.SaveAsFile("c:/Screenshot1.png", ScreenshotImageFormat.Png);

            driver.Quit();
        }

    }
}

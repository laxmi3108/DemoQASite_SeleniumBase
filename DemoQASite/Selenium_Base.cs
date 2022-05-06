using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoQASite
{
    public class Selenium_Base
    {
        private IWebDriver Driver=null;
        private IWebDriver lastInstance=null;
        private IJavaScriptExecutor Js;
        private Actions instance;

        public void init()
        {
            if (Driver == null)
            {
                Driver = new ChromeDriver();
            }
        }

        public void init(ChromeOptions options)
        {
            if (Driver == null)
            {
                Driver = new ChromeDriver(options);
            }
        }
        public void initNewWindow()
        {
            if (Driver == null)
            {
                Driver = new ChromeDriver();
            }
            else
            {
                lastInstance = Driver;
                Driver = new ChromeDriver();
            }
        }

        public void setDriver(IWebDriver driver)
        {
            this.Driver = driver;
        }

        public IWebDriver getDriver(IWebDriver driver)
        {
            return driver;
        }

        public void open(string link)
        {
            Driver = new ChromeDriver();

            Js = (IJavaScriptExecutor)Driver;

            Driver.Manage().Window.Maximize();

            Driver.Navigate().GoToUrl(link);
        }

        public void openWindow(string link)
        {
            initNewWindow();
            Driver.Navigate().GoToUrl(link);
        }

        public void refresh()
        {
            Driver.Navigate().Refresh();
        }

        public void BackBrowser()
        {
            Driver.Navigate().Back();
        }
        public void ForwardBrowser()
        {
            Driver.Navigate().Forward();
        }
        public void switchBackToPreviousDriver()
        {
            if (Driver != null)
                Driver.Quit();
            Driver = lastInstance;
        }

        public void close()
        {
            if (Driver != null)
                Driver.Close();
            if (lastInstance != null)
                lastInstance.Close();
        }

        public void exit()
        {
            if (Driver != null)
                Driver.Quit();
            if (lastInstance != null)
                lastInstance.Quit();
        }

        public void click(By by)
        {
            Driver.FindElement(by).Click();
        }

        public void click(IWebElement by)
        {
            by.Click();
        }

        public void sendKeys(By by, string key)
        {
            Driver.FindElement(by).SendKeys(key);
        }

        public void sendKeys(IWebElement by, string key)
        {
            by.SendKeys(key);
        }

        public IWebElement switchToActive()
        {
            return Driver.SwitchTo().ActiveElement();
        }

        public void switchToDefault()
        {
            Driver.SwitchTo().DefaultContent();
        }

        public IAlert switchToAlert()
        {
            return Driver.SwitchTo().Alert();
        }

        public IWebDriver switchToParentFrame()
        {
            return Driver.SwitchTo().ParentFrame();
        }

        public IWebDriver switchToFrame(int index)
        {
            return Driver.SwitchTo().Frame(index);
        }

        public void switchToanotherFrame(string key)
        {
            Driver.SwitchTo().Frame(FindXPath(key));
        }
        public void switchToWindow(int index)
        {
            Driver.SwitchTo().Window(Driver.WindowHandles[index]);
        }

        public IWebElement FindID(string id)
        {
            return Driver.FindElement(By.Id(id));
        }
        public IWebElement FindXPath(string xpath)
        {
            return Driver.FindElement(By.XPath(xpath));
        }
        public IWebElement FindName(string name)
        {
            return Driver.FindElement(By.Name(name));
        }
        public IWebElement FindCSS(string css)
        {
            return Driver.FindElement(By.CssSelector(css));
        }
        public IWebElement FindTag(string tag)
        {
            return Driver.FindElement(By.TagName(tag));
        }
        public IWebElement FindClass(string class_)
        {
            return Driver.FindElement(By.ClassName(class_));
        }
        public IWebElement FindLinkText(string tlink)
        {
            return Driver.FindElement(By.LinkText(tlink));
        }
        public IWebElement FindPartialLinkText(string plt)
        {
            return Driver.FindElement(By.PartialLinkText(plt));
        }

        public IWebElement FindWithInElement(By by, IWebElement element)
        {
            return element.FindElement(by);
        }

        public ReadOnlyCollection<IWebElement> FindAllBy(By by)
        {
            return Driver.FindElements(by);
        }

        public string getAttribute(IWebElement element, string attr)
        {
            return element.GetAttribute(attr);
        }

        public string getAttributeXpath(string Xpath, string attr)
        {
            return FindXPath(Xpath).GetAttribute(attr);
        }

        public void wait(int time)
        {
            Thread.Sleep(time);
        }

        public void execScript(string script, params object[] args)
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript(script, args);
        }

        public void clickByJS(IWebElement element)
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click();", element);
        }

        public void scrollPage(int hz, int ver)
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("window.scrollBy(" + hz + ", " + ver + ")");
        }

        public void clear(IWebElement element)
        {
            element.Clear();
        }

        public void clearAndSendKeys(IWebElement element, string key)
        {
            clear(element);
            sendKeys(element, key);
        }

        public void clearAndSendKeys(By by, string key)
        {
            var element = Driver.FindElement(by);
            clear(element);
            sendKeys(element, key);
        }

        public void acceptAlert()
        {
            switchToAlert().Accept();
        }

        public void rejectAlert()
        {
            switchToAlert().Dismiss();
        }

        public void sendKeysToAlert(string keys)
        {
            switchToAlert().SendKeys(keys);
        }

        public Actions getAction()
        {
            return (instance = new Actions(Driver));
        }
        public void clickWithAction(IWebElement element)
        {
            getAction().Click(element).Perform();
        }

        public void doubleClick(IWebElement element)
        {
            getAction().DoubleClick(element).Perform();
        }

        public void contextClick(IWebElement element)
        {
            getAction().ContextClick(element).Perform();
        }

        public void testHorizontalMovement(IWebElement element, int minPX, int maxPX)
        {
            getAction().MoveToElement(element)
                .ClickAndHold()
                .MoveByOffset(minPX, 0)
                .MoveByOffset(maxPX, 0)
                .Release()
                .Build()
                .Perform();
        }

        public void testVerticalMovement(IWebElement element, int minPY, int maxPY)
        {
            getAction().MoveToElement(element)
                .ClickAndHold()
                .MoveByOffset(0, minPY)
                .MoveByOffset(0, maxPY)
                .Release()
                .Build()
                .Perform();
        }

        public void squareMovement(IWebElement element, int minPX, int maxPX, int minPY, int maxPY)
        {
            getAction().MoveToElement(element)
                .ClickAndHold()
                .MoveByOffset(minPX, minPY)
                .MoveByOffset(maxPX, minPY)
                .MoveByOffset(maxPX, maxPY)
                .MoveByOffset(minPX, maxPY)
                .MoveByOffset(minPX, minPY)
                .Release()
                .Build()
                .Perform();
        }

        public void dragAndDrop(IWebElement movable, IWebElement container)
        {
            getAction().DragAndDrop(movable, container).Perform();
        }

        public void dragAndDropOffset(IWebElement movable, int offX, int offY)
        {
            getAction().DragAndDropToOffset(movable, offX, offY).Perform();
        }

        public void sendKeysWithAction(IWebElement element, string key)
        {
            getAction().SendKeys(element, key);
        }

        public void PressKeys(IWebElement element, string key)
        {
            getAction().KeyDown(element, key).Perform();
        }

        public void releaseKeys(IWebElement element, string key)
        {
            getAction().KeyUp(element, key).Perform();
        }

        public void keyStroke(IWebElement element, string key)
        {
            getAction()
                .KeyDown(element, key)
                .KeyUp(element, key)
                .Build()
                .Perform();
        }

        public Actions moveToElementAndClick(IWebElement webElement)
        {
            if (instance == null)
                throw new NullReferenceException("Action instance is null");
            return instance.MoveToElement(webElement).Click();
        }

        public void hoverOnto(IWebElement webElement)
        {
            getAction().MoveToElement(webElement).Perform();
        }

        public bool testForValidLink(string link)
        {
            //problem : broken link has 200 response and content-length
            try
            {
                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(link);
                webRequest.Timeout = 2500;
                webRequest.Method = "GET";
                HttpWebResponse response = (HttpWebResponse)webRequest.GetResponse();

                return response.StatusCode == HttpStatusCode.OK;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool testForValidImage(string link)
        {
            //problem : broken image has 200 response and content-length
            try
            {
                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(link);
                webRequest.Timeout = 2500;
                webRequest.Method = "GET";
                HttpWebResponse response = (HttpWebResponse)webRequest.GetResponse();

                return response.StatusCode == HttpStatusCode.OK && response.ContentLength > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

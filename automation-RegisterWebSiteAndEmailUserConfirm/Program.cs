
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace automation_RegisterWebSiteAndEmailUserConfirm
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create a driver instance for chromedriver
            IWebDriver driver = new ChromeDriver();

            //Navigate to google page
            driver.Navigate().GoToUrl("http:www.fxp.co.il");

            //Maximize the window
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);



            var reg = driver.FindElement(By.CssSelector("#sticky_menu_header > div:nth-child(7) > a"));
            reg.Click();

            var UserName = driver.FindElement(By.CssSelector("#regusername"));
            UserName.SendKeys("jjj");

            var UserNameCheckGood = driver.FindElement(By.CssSelector("#reg_verif_div"));
            if (UserNameCheckGood != null)
            {
                UserName.SendKeys("jjjssigroo");
            }

            var pass = driver.FindElement(By.CssSelector("#password"));
            pass.SendKeys("123456");
            Thread.Sleep(3000);

            var pass1 = driver.FindElement(By.CssSelector("#passwordconfirm"));
            pass1.SendKeys("123456");

            var Email = driver.FindElement(By.CssSelector("#email"));
            Email.SendKeys("itaysigroni1@walla.co.il");
            Thread.Sleep(4000);

            var Submit = driver.FindElement(By.CssSelector("#submitBtn"));
            Submit.Click();
            Thread.Sleep(4000);

            //open new tab
            ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.Navigate().GoToUrl("http:www.walla.co.il");
            Thread.Sleep(2000);

            IWebElement element = driver.FindElement(By.CssSelector("#root > div > div > header > div.first-row > div > div.promotions.no-mobile > div.promo.mail > a > div:nth-child(2) > div.line-1"));
            element.Click();
            Thread.Sleep(4000);

            var UserName1 = driver.FindElement(By.CssSelector("#wrapper > section > form > fieldset > ul > li.required-field > app-input-user-name > form > input"));
            UserName1.SendKeys("itaysigroni1");

            var Next = driver.FindElement(By.CssSelector("#wrapper > section > form > fieldset > ul > li:nth-child(3) > button"));
            Next.Click();
            Thread.Sleep(6000);

            var Pass = driver.FindElement(By.CssSelector(".label-input, input[type=email], input[type=number], input[type=password], input[type=search], input[type=tel], input[type=text], input[type=url], select, textarea"));
            //Pass.Click();
            Pass.SendKeys("A1357911a*");
            Thread.Sleep(4000);

            var Next1 = driver.FindElement(By.CssSelector("#wrapper > section > form > fieldset > button.common-button-1.full-line"));
            Next1.Click();
            Thread.Sleep(8000);

            var opene = driver.FindElement(By.CssSelector("#main-content > div > div.mail-list-wrap.mail-list-inf > div.mail-list > ul > li:nth-child(7) > div.cell.sender > span"));
            opene.Click();
            Thread.Sleep(4000);

            var verifying = driver.FindElement(By.CssSelector("#mailContent > a:nth-child(6)"));
            verifying.Click();
            Thread.Sleep(8000);

            //open new tab
            ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.Navigate().GoToUrl("http:www.fxp.co.il");
            Thread.Sleep(4000);

            var SignFxp = driver.FindElement(By.CssSelector("#sticky_menu_header > div:nth-child(6)"));
            SignFxp.Click();

            var UserNameLog = driver.FindElement(By.CssSelector("#navbar_username"));
            UserNameLog.SendKeys("jjjssigroo");

            var pass2 = driver.FindElement(By.CssSelector("#navbar_password"));
            pass2.SendKeys("123456");

            var Submit1 = driver.FindElement(By.CssSelector("#fxp2020_login_button > input"));
            Submit1.Click();
            Thread.Sleep(4000);
        }
    }
}

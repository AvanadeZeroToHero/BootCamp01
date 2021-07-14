using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Drawing;
using System.Drawing.Text;
using System.Drawing.Imaging;



namespace ZeroToHeroMeetup
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://framedlife.com.br/fotoescambo/users/login");

            //Preencher os campos usuário e senha:
            IWebElement username = driver.FindElement(By.Id("UserEmail"));
            username.SendKeys("guifreitag@gmail.com");

            IWebElement password = driver.FindElement(By.Id("UserPassword"));
            password.SendKeys("passw0rd");
            System.Threading.Thread.Sleep(2000);

            IWebElement button = driver.FindElement(By.XPath("//*[@id='UserLoginForm']/div[4]/input"));
            button.Click();

            IWebElement link = driver.FindElement(By.LinkText("Collections"));
            link.Click();

            System.Threading.Thread.Sleep(2000);

            IWebElement imagem = driver.FindElement(By.XPath("//*[@id='content']/table/tbody/tr/td[1]/center/a/img"));
            imagem.Click();
            System.Threading.Thread.Sleep(2000);

            IWebElement segundaimagem = driver.FindElement(By.XPath("//*[@id='content']/table/tbody/tr[1]/td[1]/center/a/img"));
            segundaimagem.Click();
            System.Threading.Thread.Sleep(2000);

            IWebElement lista = driver.FindElement(By.XPath("//*[@id='actions']/ul/li/a"));
            lista.Click();

            {
                string ValorAtual = driver.FindElement(By.XPath("//*[@id=\"content\"]/div[3]")).Text;
                Assert.AreEqual("La Muerte de un Miliciano", ValorAtual);
            }

            driver.Quit();


        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using FluentAssertions;
using Shouldly;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace ASOSHeaderlink.Page
{
    public class ASOSHeaderLinkPage
    {
        public IWebDriver Driver;
        public ASOSHeaderLinkPage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[2]/header[1]/div[4]/div[1]/div[2]/div[2]/nav[1]/div[1]/div[1]/button[3]/span[1]/span[1]")]
        public IWebElement clickonClothing;
        [FindsBy(How = How.XPath, Using = "//div[@class='_2yreb5T _36PJqEn']//div[@class='_2u0LGMW']//ul[@class='_1WUweTj']//li[@class='_1g1PWkA _2SQx27S']//ul[@class='_1PXCics']//li//a[@class='_1cjL45H _2Y7IAa_ CLdGn9X _1XjY6Zd'][contains(text(),'Jeans')]")]
        public IWebElement clickonJeans;
        [FindsBy(How = How.LinkText, Using = "Shoes")]
        public IWebElement clickonShoes;
        [FindsBy(How = How.LinkText, Using = "Shoes")]
        public IWebElement clickonshoes;

        public string JeansUrl = "https://www.asos.com/men/jeans/cat/?cid=4208&nlid=mw|clothing|shop+by+product";
        public string ShoesUrl = "https://www.asos.com/men/shoes-boots-trainers/shoes/cat/?cid=27116&nlid=mw|shoes|shop+by+product";

        public void clickHeader(string Link)
        {
            Task.Delay(2000).Wait();
            switch (Link)
            {
                 
                case "Clothing":
                    clickonClothing.Click();
                    break;
                case "Jeans":
                    clickonJeans.Click();
                    break;
                case "Shoes":
                    clickonshoes.Click();
                    break;
                case "shoes":
                    clickonShoes.Click();
                    break;
                default:
                    Console.WriteLine("wrong argument pass");
                        break;




            }

        }
        // reema
        public void verifyHeaderLink(string Link)
        {
            switch(Link)
            {
                case "Clothing":
                    Driver.Url.Contains(JeansUrl).Should().BeTrue();

                    break;
                case "Shoes":
                    Driver.Url.Contains(ShoesUrl).Should().BeTrue();
                    break;
                default:
                    Console.WriteLine("wrong argument pass");
                    break;
            }
        }
    }
}

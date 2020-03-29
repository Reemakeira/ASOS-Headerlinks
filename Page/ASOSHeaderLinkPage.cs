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
        [FindsBy(How = How.LinkText, Using = "Clothing")]
        public IWebElement clickonClothing;
        [FindsBy(How = How.LinkText, Using = "Jeans")]
        public IWebElement clickonJeans;
        [FindsBy(How = How.LinkText, Using = "Shoes")]
        public IWebElement clickonShoes;
        [FindsBy(How = How.LinkText, Using = "Shoes")]
        public IWebElement clickonshoes;

        public string JeansUrl = "https://www.asos.com/men/jeans/cat/?cid=4208&nlid=mw|clothing|shop+by+product";
        public string ShoesUrl = "https://www.asos.com/men/shoes-boots-trainers/shoes/cat/?cid=27116&nlid=mw|shoes|shop+by+product";

        public void clickHeader(string Link)
        {
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

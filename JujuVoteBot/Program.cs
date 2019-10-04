using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JujuVoteBot
{
    class Program
    {
        private static IWebDriver driver;
        private static string homeURL = "https://www.mtvema.com/de-de/wahl/";
        private static int voteCount = 0;

        static void Main(string[] args)
        {
            //ChromeOptions options = new ChromeOptions();
            //options.AddArguments(new List<string>() { "no-sandbox", "headless", "disable-gpu" });

            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl(homeURL);
            Console.WriteLine("Visiting Voting site...");
            while (true)
            {
                
                
                bool foundButton = false;
                Console.WriteLine("SUCHE JUJU VOTE-ABSTIMMEN BUTTON ;)");
                driver.SwitchTo().DefaultContent();
                while (foundButton == false)
                {
                    try
                    {
                        driver.FindElement(By.XPath("/html/body/div[2]/div/section/div/div[4]/div/section[1]/div/div/div/div/div/div[2]/div/div/div/div[2]/div[2]/button")).Click();
                        foundButton = true;
                    }
                    catch(Exception ex)
                    {
                        
                    }
                }

                Console.WriteLine("BUTTON GEFUNDEN UND GEVOTED!!! ");
                voteCount += 1;
                Console.WriteLine("Vote Number: " + voteCount);
                WebDriverWait wait2 = new WebDriverWait(driver, System.TimeSpan.FromSeconds(100));
            }

            
        }
    }
}

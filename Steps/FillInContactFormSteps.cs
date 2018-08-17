using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace AppliedContactTest.Steps
{
    [Binding]
    public class FillInContactFormSteps
    {
        IWebDriver driver = new ChromeDriver();

        [Given(@"I am on the contact us page")]
        public void GivenIAmOnTheContactUsPage()
        {
            driver.Url = "https://www1.appliedsystems.com/en-uk/contact-us/";
        }
        
        [Given(@"I fill in text fields")]
        public void GivenIFillInTextFields()
        {
            driver.FindElement(By.Id("Email")).SendKeys("test@test.com");
            driver.FindElement(By.Id("FirstName")).SendKeys("Emma");
            driver.FindElement(By.Id("LastName")).SendKeys("Buttery");
            driver.FindElement(By.Id("Company")).SendKeys("Test Company");
        }
        
        [Given(@"I select ""(.*)"" from the drop down")]
        public void GivenISelectFromTheDropDown(string FormChoice)
        {
            SelectElement DropDown = new SelectElement(driver.FindElement(By.Id("What_can_we_help_with__c")));
            DropDown.SelectByText(FormChoice);
            driver.Close();
        }
    }
}

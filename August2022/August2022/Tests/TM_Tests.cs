using August2022.Pages;
using August2022.Utilities;
using NUnit.Framework;

namespace August2022.Tests
{
    [TestFixture]
    [Parallelizable]
    public class TM_Tests : CommonDriver
    {
        HomePage homePageObj = new HomePage();
        TMPage tmPageObj = new TMPage();

        [Test, Order(1), Description("Check if user is able to create TM record with valid credentials")]
        public void CreateTMTest()
        {
            // Home page object initialization and definition
            homePageObj.GoToTMPage(driver);

            // TM page object initialization and definition
            tmPageObj.CreateTM(driver);
        }

        [Test, Order(2), Description("Check if user is able to edit existing TM record")]
        public void EditTMTest()
        {
            // Home page object initialization and definition
            homePageObj.GoToTMPage(driver);

            // Edit TM
            tmPageObj.EditTM(driver);
        }

        [Test, Order(3), Description("Check if user is able to delete existing TM record")]
        public void DeleteTMTest()
        {
            // Home page object initialization and definition
            homePageObj.GoToTMPage(driver);

            // Delete TM
            tmPageObj.DeleteTM(driver);
        }
    }
}

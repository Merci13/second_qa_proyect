using System;
using NUnit.Framework;
using sample.Pages;
using Xamarin.UITest;

namespace sample
{
    //Fixture used for Android
    [TestFixture(Platform.Android)]
    public class AddListTest : BaseTestFixture
    {

        public AddListTest(Platform platform) : base(platform)
        {

        }

        [Test]
        public void ClickOnTestBoard()
        {

            new LoginPage().SelectLoginButton();
            // new EmailOrUserPage().SelectLoginButton();
            new EmailOrUserPage().addTextToEmailOrUserNameTextField();
            new AddCardToTestBoardPage().ClickTestBoard();
            new AddListToBoardPage().AddListToBoardAction();



        }
    }
}

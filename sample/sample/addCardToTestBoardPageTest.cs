using System;
using NUnit.Framework;
using sample.Pages;
using Xamarin.UITest;

namespace sample
{
    //Fixture used for Android
    [TestFixture(Platform.Android)]
    public class addCardToTestBoardPageTest : BaseTestFixture
    {

        public addCardToTestBoardPageTest(Platform platform) : base(platform)
        {

        }

        [Test]
        public void addCardToTestBoard() {

            new LoginPage().SelectLoginButton();
            // new EmailOrUserPage().SelectLoginButton();
            new EmailOrUserPage().addTextToEmailOrUserNameTextField();
            new AddCardToTestBoardPage().ClickTestBoard();
            
            
        }

        
    }
}

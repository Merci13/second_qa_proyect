using System;
using NUnit.Framework;
using sample.Pages;
using Xamarin.UITest;

namespace sample
{

    //Fixture used for Android
    [TestFixture(Platform.Android)]
    public class AddCardToTestListTest : BaseTestFixture
    {

        public AddCardToTestListTest(Platform platform) : base(platform) { 



        }

    [Test]
    public void AddCardToTheList()
    {

            new LoginPage().SelectLoginButton();
            // new EmailOrUserPage().SelectLoginButton();
            new EmailOrUserPage().addTextToEmailOrUserNameTextField();
            new AddCardToTestBoardPage().ClickTestBoard();
            new AddListToBoardPage().AddListToBoardAction();
            new AddCardToListPage().AddCardToListTestAction();



        }
}
}

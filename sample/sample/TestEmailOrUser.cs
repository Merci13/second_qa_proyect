using System;
using NUnit.Framework;
using Xamarin.UITest;

namespace sample
{
    //Fixture used for Android
    [TestFixture(Platform.Android)]
    public class TestEmailOrUser : BaseTestFixture
    {
        public TestEmailOrUser(Platform platform): base(platform)
        {


        }
            [Test]
        public void ClickLogInButton()
        {
            //app.Repl();

            new LoginPage().SelectLoginButton();


        }



    }//end
}

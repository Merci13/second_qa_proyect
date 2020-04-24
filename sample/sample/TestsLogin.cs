using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using sample.Pages;
using Xamarin.UITest;
using Xamarin.UITest.Android;
using Xamarin.UITest.Queries;


    namespace sample
    {
    //Fixture used for Android
    [TestFixture(Platform.Android)]
    public class Tests : BaseTestFixture
        {
           /// Platform platform = Platform.Android;
        
        

            public Tests(Platform platform): base(platform) {

            }
 

        [Test]
      public void ClickLogInButton()
        {
            //app.Repl();

            new LoginPage().SelectLoginButton();
         

        }
  
        
        }
    }

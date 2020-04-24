using System;


using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace sample.Pages
{
    public class LoginPage : BasePage
    {
        readonly Query loginButton;
       
        protected override PlatformQuery Trait => new PlatformQuery {
         

            Android = x => x.Id("view_pager")
           
        };

        public LoginPage()
        {

            if (OnAndroid)
            {
       
                loginButton = x => x.Id("log_in_button");
               // app.Tap(x => x.Button("Log in"));
                   
                //Tapping coordinates [ 781, 1545 ]. 

            }

        }

        public void SelectLoginButton()
        {
           // app.WaitForElement(loginButton);
            app.Tap(loginButton);
        }

    }
}

using System;
using Android.App;
using FomeLine.Auth;
using FomeLine.Droid;
using Xamarin.Auth;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(LoginPage), typeof(LoginPageRendererDroid))]
namespace FomeLine.Droid
{
   public  class LoginPageRendererDroid : PageRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
        {
            base.OnElementChanged(e);

            var activity = this.Context as Activity;

            var auth = new OAuth2Authenticator(
                clientId: "", // your OAuth2 client id
                scope: "", // the scopes for the particular API you're accessing, delimited by "+" symbols
                authorizeUrl: new Uri(""), // the auth URL for the service
                redirectUrl: new Uri("")); // the redirect URL for the service

            // If authorization succeeds or is canceled, .Completed will be fired.
            auth.Completed += (sender, eventArgs) =>
            {
                if (eventArgs.IsAuthenticated)
                {
                    App.SuccessFulLoginAction.Invoke();
                    // Use eventArgs.Account to do wonderful things
                    var token = eventArgs.Account.Properties["access_token"];
                    App.SaveToken(token);
                }
                else
                {
                    // The user cancelled
                }
            };


            activity.StartActivity(auth.GetUI(activity));
        }
    }
}
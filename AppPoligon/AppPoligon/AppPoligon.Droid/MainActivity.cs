using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace AppPoligon.Droid
{
    [Activity(Label = "AppPoligon", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
                    

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());

            //Esto hacemos que podamos compartir cualquier texto con cualquier aplicación, nos sale el dialogo para compartir con todo
            Intent sendIntent = new Intent();
            sendIntent.SetAction(Intent.ActionSend);
            sendIntent.PutExtra(Intent.ExtraText, "This is my text to send.");
            sendIntent.SetType("text/plain");
            StartActivity(sendIntent);
            //////////////////////////////////////////

        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Threading;

namespace Shark
{
    [Activity(Label = "Sharks-Team", MainLauncher = true, Theme = "@style/Theme.Splash", NoHistory = true, Icon = "@drawable/hanyiocon")]
    public class loadingscreen : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            // base.OnCreate(savedInstanceState);
            Thread.Sleep(2600);
            //Start Activity1 Activity  
            StartActivity(typeof(MainActivity));
        }
    }
}
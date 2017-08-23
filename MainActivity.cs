using Android.App;
using Android.Widget;
using Android.OS;
using Android.Webkit;
using Plugin.Connectivity;
using Android.Content;
using Android.Views;

namespace Shark
{
    [Activity(Label = "Sharks Team", Icon = "@drawable/bitbolicon")]
    public class MainActivity : Activity
    {
        WebView WV;
        // static Button btn_back;
        static TextView txt_loadi;
        public void about_code()
        {
            WV.Settings.JavaScriptEnabled = true;
            if (CrossConnectivity.Current.IsConnected)
            {
                txt_loadi.Text = "loading.....";
                // btn_back.Text = "loading...";
                // Toast.MakeText(this, "Loading...", ToastLength.Long).Show();
                // Toast.MakeText(this, "Loading...", ToastLength.Long).Show();
                WV.LoadUrl("http://www.sharksteamforallsports.com/ar/about");
                WV.Settings.LoadWithOverviewMode = true;
                WV.SetWebViewClient(new HelloWebViewClient());
            }
            else
            {
                var alert = new AlertDialog.Builder(this);

                alert.SetMessage("Please connect to the Internet first, then click Refresh the page!");
                // alert.SetIcon(Resource.Drawable.alerticon);
                alert.SetPositiveButton("OK", delegate
                {

                });
                alert.SetNeutralButton("Refresh the page", delegate
                {
                    about_code();
                });

                alert.Show();
            }
        }
        public void main_code()
        {
            WV.Settings.JavaScriptEnabled = true;
            if (CrossConnectivity.Current.IsConnected)
            {
                txt_loadi.Text = "loading.....";
                // btn_back.Text = "loading...";
                //  Toast.MakeText(this, "Loading...", ToastLength.Long).Show();
                // Toast.MakeText(this, "Loading...", ToastLength.Long).Show();
                WV.LoadUrl("http://www.sharksteamforallsports.com/ar/");
                WV.Settings.LoadWithOverviewMode = true;
                WV.SetWebViewClient(new HelloWebViewClient());
            }
            else
            {
                var alert = new AlertDialog.Builder(this);

                alert.SetMessage("Please connect to the Internet first, then click Refresh the page!");
                // alert.SetIcon(Resource.Drawable.alerticon);
                alert.SetPositiveButton("OK", delegate
                {
                    //var url = Android.Net.Wifi.WifiStatus.Enabled;
                    //Intent intent = new Intent(Intent.ActionView,url);
                    //StartActivity(intent);
                });
                alert.SetNeutralButton("Refresh the page", delegate
                {
                    main_code();
                });

                alert.Show();
            }
        }
        public void Activities_code()
        {
            WV.Settings.JavaScriptEnabled = true;
            if (CrossConnectivity.Current.IsConnected)
            {
                txt_loadi.Text = "loading.....";
                //btn_back.Text = "loading...";
                //  Toast.MakeText(this, "Loading...", ToastLength.Long).Show();
                // Toast.MakeText(this, "Loading...", ToastLength.Long).Show();
                WV.LoadUrl("http://www.sharksteamforallsports.com/ar/activities");
                WV.Settings.LoadWithOverviewMode = true;
                WV.SetWebViewClient(new HelloWebViewClient());
            }
            else
            {
                var alert = new AlertDialog.Builder(this);

                alert.SetMessage("Please connect to the Internet first, then click Refresh the page!");
                // alert.SetIcon(Resource.Drawable.alerticon);
                alert.SetPositiveButton("OK", delegate
                {

                });
                alert.SetNeutralButton("Refresh the page", delegate
                {
                    Activities_code();
                });

                alert.Show();
            }
        }
        public void News_code()
        {
            WV.Settings.JavaScriptEnabled = true;
            if (CrossConnectivity.Current.IsConnected)
            {
                txt_loadi.Text = "loading.....";
                // btn_back.Text = "loading...";
                //  Toast.MakeText(this, "Loading...", ToastLength.Long).Show();
                // Toast.MakeText(this, "Loading...", ToastLength.Long).Show();
                WV.LoadUrl("http://www.sharksteamforallsports.com/ar/news");
                WV.Settings.LoadWithOverviewMode = true;
                WV.SetWebViewClient(new HelloWebViewClient());
            }
            else
            {
                var alert = new AlertDialog.Builder(this);

                alert.SetMessage("Please connect to the Internet first, then click Refresh the page!");
                // alert.SetIcon(Resource.Drawable.alerticon);
                alert.SetPositiveButton("OK", delegate
                {

                });
                alert.SetNeutralButton("Refresh the page", delegate
                {
                    News_code();
                });

                alert.Show();
            }
        }
        public void Careers_code()
        {
            txt_loadi.Text = "loading.....";
            WV.Settings.JavaScriptEnabled = true;
            if (CrossConnectivity.Current.IsConnected)
            {
                // btn_back.Text = "loading...";
                //  Toast.MakeText(this, "Loading...", ToastLength.Long).Show();
                // Toast.MakeText(this, "Loading...", ToastLength.Long).Show();
                WV.LoadUrl("http://www.sharksteamforallsports.com/ar/careers");
                WV.Settings.LoadWithOverviewMode = true;
                WV.SetWebViewClient(new HelloWebViewClient());
            }
            else
            {
                var alert = new AlertDialog.Builder(this);

                alert.SetMessage("Please connect to the Internet first, then click Refresh the page!");
                // alert.SetIcon(Resource.Drawable.alerticon);
                alert.SetPositiveButton("OK", delegate
                {

                });
                alert.SetNeutralButton("Refresh the page", delegate
                {
                    Careers_code();
                });

                alert.Show();
            }
        }
        public void Contact_code()
        {
            txt_loadi.Text = "loading.....";
            WV.Settings.JavaScriptEnabled = true;
            if (CrossConnectivity.Current.IsConnected)
            {
                // btn_back.Text = "loading...";
                //  Toast.MakeText(this, "Loading...", ToastLength.Long).Show();
                // Toast.MakeText(this, "Loading...", ToastLength.Long).Show();
                WV.LoadUrl("http://www.sharksteamforallsports.com/ar/contact");
                WV.Settings.LoadWithOverviewMode = true;
                WV.SetWebViewClient(new HelloWebViewClient());
            }
            else
            {
                var alert = new AlertDialog.Builder(this);

                alert.SetMessage("Please connect to the Internet first, then click Refresh the page!");
                // alert.SetIcon(Resource.Drawable.alerticon);
                alert.SetPositiveButton("OK", delegate
                {

                });
                alert.SetNeutralButton("Refresh the page", delegate
                {
                    Contact_code();
                });

                alert.Show();
            }
        }
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
             SetContentView (Resource.Layout.Main);
            SetContentView(Resource.Layout.Main);
            WV = FindViewById<WebView>(Resource.Id.webView1);
            txt_loadi = FindViewById<TextView>(Resource.Id.textView1);
            main_code();
        }
        public class HelloWebViewClient : WebViewClient
        {
            public override bool ShouldOverrideUrlLoading(WebView view, string url)
            {
                view.LoadUrl(url);
                return true;
            }

            public override void OnPageFinished(WebView view, string url)
            {
               // txt_loadi.Visibility = ViewStates.Invisible;
                txt_loadi.Text = "";
                // btn_back.Text = "<<";
            }
        }
        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.main_menu, menu);
            return base.OnCreateOptionsMenu(menu);
        }
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.Home:
                    //do something
                    // Toast.MakeText(this, "You are already in the Home page ^_^!", ToastLength.Long).Show(); break;
                    main_code(); break;

                case Resource.Id.about:
                    about_code();
                    break;

                case Resource.Id.Activities:
                    Activities_code();
                    break;

                case Resource.Id.News:
                    News_code();
                    break;

                case Resource.Id.Careers:
                    Careers_code();
                    break;

                case Resource.Id.Contact:
                    var alert3 =new AlertDialog.Builder(this);
                    alert3.SetTitle("Call us");
                    alert3.SetMessage("Do you want to call us now?");
                    alert3.SetPositiveButton("Yes", delegate
                     {
                         var dial = Android.Net.Uri.Parse("tel:" + 01277778586);
                         Intent call = new Intent(Intent.ActionDial, dial);
                         StartActivity(call);
                     });
                    alert3.SetNegativeButton("No,only browse the page now", delegate { Contact_code(); });
                    alert3.Show();
                    break;

                case Resource.Id.Exit:
                    //Close_App();
                    var alert2 = new AlertDialog.Builder(this);
                    alert2.SetTitle("Close");
                    alert2.SetMessage("Do you want to close the app!?");
                    alert2.SetPositiveButton("Yes", delegate
                    {
                        Close_App();
                    });
                    alert2.SetNegativeButton("No", delegate { });
                    alert2.Show();
                    break;

            }
            return base.OnOptionsItemSelected(item);
        }
        public void Close_App()
        {
            Android.OS.Process.KillProcess(Android.OS.Process.MyPid());
        }
        public override void OnBackPressed()
        {
            WV.GoBack();
            
        }
    }
}


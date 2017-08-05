using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Xamarin.Controls;
using Android.Views;

namespace R_Calculatour
{
    [Activity(Label = "R_Calculatour", MainLauncher = true, Icon = "@drawable/add")]
    public class MainActivity : Activity
    {
        double num1, num2; char op;

      


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);



            #region btnArkam
            var btn1 = FindViewById<Button>(Resource.Id.btn1);
            var btn2 = FindViewById<Button>(Resource.Id.btn2);
            var btn3 = FindViewById<Button>(Resource.Id.btn3);
            var btn4 = FindViewById<Button>(Resource.Id.btn4);
            var btn5 = FindViewById<Button>(Resource.Id.btn5);
            var btn6 = FindViewById<Button>(Resource.Id.btn6);
            var btn7 = FindViewById<Button>(Resource.Id.btn7);
            var btn8 = FindViewById<Button>(Resource.Id.btn8);
            var btn9 = FindViewById<Button>(Resource.Id.btn9);
            var btn_yasawy= FindViewById<Button>(Resource.Id.btn_ysawy);
            var btn_dot = FindViewById<Button>(Resource.Id.btn_dot);
            var btn_zero = FindViewById<Button>(Resource.Id.btn_zreo);
            var btn_clear = FindViewById<Button>(Resource.Id.btnClear);

            #endregion
            #region 3mlyaty
            var gam3 = FindViewById<Button>(Resource.Id.gam3);
            var tar7 = FindViewById<Button>(Resource.Id.tar7);
            var darb = FindViewById<Button>(Resource.Id.darb);
            var qsma = FindViewById<Button>(Resource.Id.qsma);
            #endregion
            var result = FindViewById<EditText>(Resource.Id.editText1);
            btn1.Click += delegate { result.Text += "1"; };
            btn2.Click += delegate { result.Text += "2"; };
            btn3.Click += delegate { result.Text += "3"; };
            btn4.Click += delegate { result.Text += "4"; };
            btn5.Click += delegate { result.Text += "5"; };
            btn6.Click += delegate { result.Text += "6"; };
            btn7.Click += delegate { result.Text += "7"; };
            btn8.Click += delegate { result.Text += "8"; };
            btn9.Click += delegate { result.Text += "9"; };
            btn_zero.Click += delegate { result.Text += "0"; };
            btn_dot.Click += delegate { result.Text += "."; };
            gam3.Click += delegate
                {
                    try
                    {
                        op = '+'; num1 = Convert.ToDouble(result.Text);
                    result.Text = "";
                    }
                    catch { };
                };
                tar7.Click += delegate
                {
                    try
                    {
                        op = '-'; num1 = Convert.ToDouble(result.Text);
                    result.ClearComposingText(); result.Text = "";
                    }
                    catch { };
                };
                darb.Click += delegate
                {
                    try
                    {
                        op = '*'; num1 = Convert.ToDouble(result.Text);
                    result.ClearComposingText(); result.Text = "";
                    }
                    catch { };
                };
                qsma.Click += delegate
                {
                    try
                    {

                        op = '/'; num1 = Convert.ToDouble(result.Text);
                    result.ClearComposingText(); result.Text = "";
                    }
                    catch { };
                };
                btn_clear.Click += delegate { result.Text = ""; };
                btn_yasawy.Click += delegate
                {
                    num2 = Convert.ToDouble(result.Text);
                    switch (op)
                    {
                        case '+': result.Text = (num1 + num2).ToString(); break;
                        case '-': result.Text = (num1 - num2).ToString(); break;
                        case '*': result.Text = (num1 * num2).ToString(); break;
                        case '/': result.Text = (num1 / num2).ToString(); break;
                    }
                };
           
        }
        //public override bool OnCreateOptionsMenu(IMenu menu)
        //{
        //    MenuInflater.Inflate(Resource.Menu.menu, menu);
        //    return base.OnCreateOptionsMenu(menu);
        //}
        //public override bool OnOptionsItemSelected(IMenuItem item)
        //{
        //    switch (item.ItemId)
        //    {
        //        case Resource.Id.home;
        //            //do something
        //            return true;

        //    }
        //    return base.OnOptionsItemSelected(item);
        //}
    }
}


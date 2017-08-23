//ادرج اداه webview فى ملف الaxml 

// setting layout
        Button button = FindViewById<Button>(Resource.Id.MyButton);

        WebView webv1 = FindViewById<WebView>(Resource.Id.webView1);
        webv1.Settings.JavaScriptEnabled = true; //لتفعيل الجافا اسكريبت
        webv1.LoadUrl("http://google.com/"); //الرابط المراد عرضه
        webv1.Settings.LoadWithOverviewMode = true; //تعنى ان اى صفحة جديدة ستفتح داخل الويب فيو
        webv1.SetWebViewClient(new HelloWebViewClient());
      
            webv1.GoBack(); //تضع هذه الميثود فى حدث للرجوع للخلف
            //webv1.GoForward(); //تضع هذه الميثود فى حدث للرجوع لللاحق

        public override void OnBackPressed() //جعل زر الرجوع فى الهاتف نفسه هو الذى يرجع اللى الخلف وليس اللى النافذة السابقة
        {
            webv1.GoBack();
            
        }

 //load url inside
        public class HelloWebViewClient : WebViewClient
{
    public override bool ShouldOverrideUrlLoading(WebView view, string url) //اثناء تحميل الصفحة
    {
        view.LoadUrl(url);
        return true;
    }
    public override void OnPageFinished(WebView view, string url) //عندما ينتهى تحميل الصفحة
    {

    }
}



using RedditRss.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RedditRss.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PostView : ContentPage
    {
        public PostView()
        {
            InitializeComponent();
            Xamarin.Forms.PlatformConfiguration.iOSSpecific.Page.SetUseSafeArea(this, true);
        }
        public PostView(Models.Entry entry)
        {
            InitializeComponent();
            Xamarin.Forms.PlatformConfiguration.iOSSpecific.Page.SetUseSafeArea(this, true);
            webView.Source = entry.Link.Href;
        }
    }
}
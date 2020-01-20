using Microsoft.AppCenter.Crashes;
using RedditRss.Helpers;
using RedditRss.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RedditRss.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PostView : ContentPage
    {
        private readonly PostViewModel _postViewModel;
        public PostView()
        {
            InitializeComponent();
            Xamarin.Forms.PlatformConfiguration.iOSSpecific.Page.SetUseSafeArea(this, true);
            _postViewModel = BindingContext as PostViewModel;
        }
        public PostView(Models.Entry entry)
        {
            InitializeComponent();
            Xamarin.Forms.PlatformConfiguration.iOSSpecific.Page.SetUseSafeArea(this, true);

            _postViewModel = BindingContext as PostViewModel;
            _postViewModel.SelectedPost = entry;

            try
            {

                Title = entry.Title;
                postImage.Source = entry.Link.Href;
                creatorLabel.Text = entry.Author.Name;
                dateLabel.Text = entry.Updated != null ? DateTime.Parse(entry.Updated).ToString("MMMM dd") : string.Empty;
                htmlWebViewSource.Html = entry.Content.Text;
                var properties = new Dictionary<string, string>()
                {
                    { "Feed post", entry.Title }
                };
                AppCenterHelper.TrackEvent(properties).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                var properties = new Dictionary<string, string>()
                {
                    { "Feed post",$"{entry.Title}"}
                };

                AppCenterHelper.TrackError(ex, properties).ConfigureAwait(false);
            }
        }

    }
}
using RedditRss.Interfaces;
using RedditRss.ViewModels.Base;
using System.Windows.Input;
using Xamarin.Forms;

namespace RedditRss.ViewModels
{
    public class PostViewModel : ViewModelBase
    {
        private Models.Entry _selectedPost;
        public Models.Entry SelectedPost 
        {
            get { return _selectedPost; }
            set 
            {
                _selectedPost = value;
                OnPropertyChanged();
            }
        }
        public ICommand ShareCommand { get; set; }

        public PostViewModel()
        {
            SelectedPost = new Models.Entry();
            ShareCommand = new Command(Share);
        }

        private void Share() 
        {
            IShare share = DependencyService.Get<IShare>();
            share.Show("Post from FInance", SelectedPost.Link.Href);
        }
    }
}

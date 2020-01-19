using RedditRss.Views;
using Xamarin.Forms;

namespace RedditRss.Behavior
{
    public class ListViewBehavior : Behavior<ListView>
    {
        private ListView _listView;

        protected override void OnAttachedTo(ListView bindable)
        {

            base.OnAttachedTo(bindable);
            _listView = bindable;
            bindable.ItemSelected += Bindable_ItemSelected;
        }

        private void Bindable_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedItem = _listView.SelectedItem as Models.Entry;

            Application.Current.MainPage.Navigation.PushAsync(new PostView(selectedItem));
        }

        protected override void OnDetachingFrom(ListView bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.ItemSelected -= Bindable_ItemSelected;
        }

    }
}

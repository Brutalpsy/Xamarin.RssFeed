using RedditRss.Models;
using RedditRss.ViewModels.Base;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

namespace RedditRss.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public Feed Feed { get; set; }

        public MainViewModel()
        {
            ReadRss();
        }

        public void ReadRss()
        {
            var ser = new XmlSerializer(typeof(Feed));

            using (var client = new WebClient())
            {
                var xml = Encoding.Default.GetString(client.DownloadData("https://www.reddit.com/.rss"));
                var stringReader = new StringReader(xml);
                Feed = (Feed)ser.Deserialize(stringReader);
            }
        }
    }
}

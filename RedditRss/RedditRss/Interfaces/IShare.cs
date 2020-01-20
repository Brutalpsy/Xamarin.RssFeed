using System.Threading.Tasks;

namespace RedditRss.Interfaces
{
    public interface IShare
    {
        Task Show(string title, string url);
    }
}

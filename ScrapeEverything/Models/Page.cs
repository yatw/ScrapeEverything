
namespace ScrapeEverything.Models
{
    public class Page
    {

        public string url;
        public bool requireLogin;
        public string userNameFieldId;
        public string userName;
        public string userPasswordFieldId;
        public string userPassword;
        public string btnValue;

        public Page(string url)
        {
            this.url = url;
        }
    }
}
using System.Threading.Tasks;
using System.Net.Http;
using UserInterface.Library.Models;

namespace UserInterface.Library.Api
{
    public interface IAPIHelper
    {
        Task<AuthenticateUser> Authenticate(string username, string password);
        Task GetLoggedInUserInfo(string token);
        HttpClient ApiClient{get;}
        
    }
}

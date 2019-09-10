using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Net.Http;
using UserInterface.Library.Models;


namespace UserInterface.Library.Api
{
    public class APIHelper : IAPIHelper
    {
        private ILoggedInUserModel _loggedInUserModel;

        private HttpClient _apiClient;
        public HttpClient ApiClient
        {
            get
            {
                return _apiClient;
            }
    
        }
        public APIHelper (ILoggedInUserModel loggedInUserModel)
	    {
            InitializeClient();
            _loggedInUserModel = loggedInUserModel;
	    }
        private void InitializeClient()
        {
            string api = ConfigurationManager.AppSettings["api"];
            _apiClient = new HttpClient();
            _apiClient.DefaultRequestHeaders.Accept.Clear();
            _apiClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            _apiClient.BaseAddress = new Uri(api);


        }

        public async Task GetLoggedInUserInfo(string token)
        {
            ApiClient.DefaultRequestHeaders.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add( new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            ApiClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            
            using (HttpResponseMessage response = await ApiClient.GetAsync("/api/User"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<LoggedInUserModel>();
                    _loggedInUserModel.CreatedDate = result.CreatedDate;
                    _loggedInUserModel.EmailAddress = result.EmailAddress;
                    _loggedInUserModel.FirstName = result.FirstName;
                    _loggedInUserModel.Id = result.Id;
                    _loggedInUserModel.Token = token;
                    _loggedInUserModel.LastName = result.LastName;                    
                }
                else 
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        
        }

        public async Task<AuthenticateUser> Authenticate(string username, string password)
        {
            var data = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string,string>("grant_type", "password"),
                new KeyValuePair<string,string>("username", username),
                new KeyValuePair<string,string>("password", password),
            
            });
            using (HttpResponseMessage response = await ApiClient.PostAsync("/Token", data))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<AuthenticateUser>();
                    return result;
                }
                else 
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterface.Library.Api;
using UserInterface.Library.Models;
using System.Net.Http;

namespace UserInterface.Library.Api
{
    public class PhraseEndpoint : UserInterface.Library.Api.IPhraseEndpoint
    {
        private IAPIHelper _apiHelper;
        public PhraseEndpoint (IAPIHelper apiHelper)
	    {
            _apiHelper = apiHelper;   
	    }
        public async Task<List<PhraseModel>> GetAll()
        {
         
            using (HttpResponseMessage response = await _apiHelper.ApiClient.GetAsync("/api/Phrase/Get"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<List<PhraseModel>>();
                    return result;
                 }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
         
        }
        public async Task<int> PostPhrase(PhraseModel NewPhrase)
        {
            using (HttpResponseMessage response = await _apiHelper.ApiClient.PostAsJsonAsync("/api/Phrase/Add", NewPhrase))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<int>();
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

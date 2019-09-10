using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterface.Library.Models;
using System.Net.Http;

namespace UserInterface.Library.Api
{
    public class DeckEndpoint : UserInterface.Library.Api.IDeckEndpoint
    {
        private IAPIHelper _apiHelper;
        public DeckEndpoint( IAPIHelper apiHelper)
	    {
            _apiHelper = apiHelper;        
	    }

        public async Task<List<DeckModel>> GetAll()
        {
            using (HttpResponseMessage response = await _apiHelper.ApiClient.GetAsync("api/Deck"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<List<DeckModel>>();
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

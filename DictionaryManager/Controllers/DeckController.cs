using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DictionaryManager.Library.DataAccess;
using DictionaryManager.Library.Models;

namespace DictionaryManager.Controllers
{
    [Authorize]
    public class DeckController : ApiController
    {
        public List<DeckModel> Get()
        {
            DeckData data = new DeckData();
            return data.GetDecks();
        }
    }
}

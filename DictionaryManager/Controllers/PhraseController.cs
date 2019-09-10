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
    public class PhraseController : ApiController
    {
         [Route("api/Phrase/Get")]
       
        public List<PhraseModel> Get()
        {
            PhraseData data = new PhraseData();
            return data.GetPhrases();        
        }

        
        [HttpPost]
        [Route ("api/Phrase/Add")]
        public int Add(PhraseModel newPhrase)
        {
            PhraseData data = new PhraseData();
            return data.Add(newPhrase);

        }

    }
}

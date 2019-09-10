using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DictionaryManager.Library.Models;
using DictionaryManager.Library.DataAccess.Internal;


namespace DictionaryManager.Library.DataAccess
{
    public class PhraseData
    {
        public List<PhraseModel> GetPhrases()
        {
            SqlDataAccess sql = new SqlDataAccess();

            var p = new {};

            var rows = sql.LoadData<PhraseModel, dynamic>("dbo.spPhrase_GetAll", p, "DictionaryData");

            return rows;       
        
        }
        public int Add(PhraseModel newPhrase)
        {
            SqlDataAccess sql = new SqlDataAccess();

            var DeckInfo = sql.LoadData<DeckModel,dynamic>("dbo.spDeck_GetById", new {Id = newPhrase.DeckId}, "DictionaryData");
            
            if(DeckInfo.Count() == 0)
            {
                newPhrase.DeckId = null; 
            }
            
            
            int result = sql.SaveData<PhraseModel,dynamic>("spPhrase_Insert", newPhrase, "DictionaryData");

            return result;
        }
    }
}

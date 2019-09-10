using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DictionaryManager.Library.Models;
using DictionaryManager.Library.DataAccess.Internal;


namespace DictionaryManager.Library.DataAccess
{
    public class DeckData
    {
        public List<DeckModel> GetDecks()
        {
            SqlDataAccess sql = new SqlDataAccess();
            
            return sql.LoadData<DeckModel, dynamic>("spDecks_GetAll", new { }, "DictionaryData");
        
        }    
    }
}

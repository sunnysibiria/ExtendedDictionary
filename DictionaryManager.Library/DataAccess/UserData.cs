using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DictionaryManager.Library.Models;
using DictionaryManager.Library.DataAccess.Internal;

namespace DictionaryManager.Library.DataAccess
{
    public class UserData
    {
        public UserModel GetUserById(string Id) 
        {
            SqlDataAccess sql = new SqlDataAccess();

            var p = new{Id = Id};
 
            var rows = sql.LoadData<UserModel, dynamic>("dbo.spUserLookup", p, "DictionaryData");

            return rows.First();
        }

    }
}

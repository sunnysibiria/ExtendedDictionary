using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DictionaryManager.Library.DataAccess;
using DictionaryManager.Library.Models;
using Microsoft.AspNet.Identity;

namespace DictionaryManager.Controllers
{
    [Authorize]
    public class UserController : ApiController
    {

        public UserModel GetById()
        {
            
            string Id = RequestContext.Principal.Identity.GetUserId();
            UserData user = new UserData();
            return user.GetUserById(Id);
        }

    }
}

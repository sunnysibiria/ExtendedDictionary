using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Swashbuckle.Swagger;
namespace DictionaryManager.App_Start
{
    public class AuthorizationOperationFilter:IOperationFilter
    {
        public void Apply(Operation operation, SchemaRegistry schemaRegistry, System.Web.Http.Description.ApiDescription apiDescription)
        {
            if (operation.parameters == null)
            { 
                operation.parameters = new List<Parameter>();
            }
            operation.parameters.Add(new Parameter
            { 
                name="Authorization",
                @in="header",
                description="access token",
                required=false,
                type="string"


            });
        }
    }
}
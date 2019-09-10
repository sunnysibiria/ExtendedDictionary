using System;
namespace UserInterface.Library.Api
{
    public interface IDeckEndpoint
    {
        System.Threading.Tasks.Task<System.Collections.Generic.List<UserInterface.Library.Models.DeckModel>> GetAll();
    }
}

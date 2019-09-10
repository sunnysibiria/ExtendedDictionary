using System;
namespace UserInterface.Library.Api
{
    public interface IPhraseEndpoint
    {
        System.Threading.Tasks.Task<System.Collections.Generic.List<UserInterface.Library.Models.PhraseModel>> GetAll();
        System.Threading.Tasks.Task<int> PostPhrase(UserInterface.Library.Models.PhraseModel NewPhrase);
    
    }
}

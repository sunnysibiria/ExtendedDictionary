using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryManager.Library.Models
{
    public class PhraseModel
    {
        public int Id { get; set; }
        public string PhraseName { get; set; }
        public string Translate { get; set; }
        public string Translate2 { get; set; }
        public string Translate3 { get; set; }
        public string Hint { get; set; }
        public int? DeckId { get; set; }

    }
}

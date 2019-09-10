using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface.Library.Models
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

        public string Description
        {
            get
            {
                if (string.IsNullOrEmpty(Translate2)) { return Translate; };

                if (string.IsNullOrEmpty(Translate3)) { return Translate + "; " + Translate2; }
                else
                {
                    return Translate + "; " + Translate2 + "; " + Translate3;
                }
            }
        }
        public override string ToString()
        {
            return string.Format("Id={0} PhraseName={1} Description={2} Hint={3} DeckId={4}", Id, PhraseName, Description, Hint, DeckId);
        }
    }
}

using SpellChecker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellChecker.Contracts
{
    interface ISpellbook
    {
        IEnumerable<Spell> GetSpells();
        bool AddEntry(SpellbookEntry entry);
        bool DeleteEntry(int entryId);
    }
}

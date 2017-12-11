using Spellchecker.ViewModels;
using SpellChecker.Data;
using SpellChecker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellChecker.Contracts
{
    public interface ISpell
    {
        IEnumerable<SpellListItem> GetAllSpells();
        Data.Spell GetSpellById(int spellId);
    }
}

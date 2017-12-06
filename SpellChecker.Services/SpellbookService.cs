using SpellChecker.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpellChecker.Models;
using SpellChecker.Data;

namespace SpellChecker.Services
{
    public class SpellbookService : ISpellbook
    {
        private readonly Guid _userId;

        public SpellbookService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateSpellbook(Spellbook spellbook)
        {
            var entity =
                new SpellbookEntity()
                {
                    SpellbookId = spellbook.SpellbookId,
                    SpellbookName = spellbook.SpellbookName,
                    UserId = _userId
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Spellbooks.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public bool AddEntry(Spell spell)
        {
            throw new NotImplementedException();
        }

        public bool DeleteEntry(int entryId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Spell> GetSpells()
        {
            throw new NotImplementedException();
        }
    }
}

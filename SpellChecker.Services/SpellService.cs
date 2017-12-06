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
    public class SpellService : ISpell
    {
        public Spell GetSpellById(int spellId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Spells
                        .Single(e => e.SpellId == spellId);

                return
                    new Spell
                    {
                        SpellId = entity.SpellId,
                        SpellName = entity.SpellName,
                        SpellLevel = entity.SpellLevel,
                        SpellSchool = entity.SpellSchool,
                        CastingTime = entity.CastingTime,
                        SpellRange = entity.SpellRange,
                        VComponents = entity.VComponents,
                        SComponents = entity.SComponents,
                        HasMComponents = entity.HasMComponents,
                        HasExpensiveMComponents = entity.HasExpensiveMComponents,
                        MComponents = entity.MComponents,
                        Duration = entity.Duration,
                        Ritual = entity.Ritual,
                        SpellTextA = entity.SpellTextA,
                        SpellTextB = entity.SpellTextB,
                        SpellTextC = entity.SpellTextC,
                        SpellTextD = entity.SpellTextD,
                        SpellTextE = entity.SpellTextE,
                        SpellTextF = entity.SpellTextF,
                        SpellTextG = entity.SpellTextG,
                        SpellTextH = entity.SpellTextH,
                        SpellTextI = entity.SpellTextI,
                        SpellSource = entity.SpellSource,
                        BrdSpell = entity.BrdSpell,
                        ClrSpell = entity.ClrSpell,
                        DrdSpell = entity.DrdSpell,
                        PalSpell = entity.PalSpell,
                        RngSpell = entity.RngSpell,
                        SorSpell = entity.SorSpell,
                        WarSpell = entity.WarSpell,
                        WizSpell = entity.WizSpell
                    };
            }
        }
    }
}

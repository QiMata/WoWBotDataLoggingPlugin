using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLoggingPlugin.Shim
{
    class Aura
    {
        public static Aura Map(wManager.Wow.Class.Aura aura)
        {
            return new Aura
            {
                SlotId = aura.SlotId,
                SpellId = aura.SpellId,
                Stack = aura.Stack,
                TimeEnd = aura.TimeEnd,
                TimeLeft = aura.TimeLeft,
                TimeLeftSeconde = aura.TimeLeftSeconde,
                Spell = aura.GetSpell == null ? Spell.Map(aura.GetSpell) : null
            };
        }

        public uint SlotId { get; set; }
        public uint SpellId { get; set; }
        public int Stack { get; set; }
        public int TimeEnd { get; set; }
        public int TimeLeft { get; set; }
        public double TimeLeftSeconde { get; set; }
        public Spell Spell { get; set; }
    }
}

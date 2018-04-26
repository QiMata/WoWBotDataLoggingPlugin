using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLoggingPlugin.Shim
{
    class Spell
    {
        public static Spell Map(wManager.Wow.Class.Spell spell)
        {
            return new Spell
            {
                Id = spell.Id,
                KnownSpell = spell.KnownSpell,
                CastTime = spell.CastTime,
                Icon = spell.Icon,
                MinRange = spell.MinRange,
                Name = spell.Name,
                NameInGame = spell.NameInGame,
                SubName = spell.SubName,
                MaxRange = spell.MaxRange,
                IsSpellUsable = spell.IsSpellUsable,
                IsInActionBar = spell.IsInActionBar,
                IsDistanceGood = spell.IsDistanceGood,
                BuffStack = spell.BuffStack,
                TargetBuffStack = spell.TargetBuffStack,
                BuffTimeLeft = spell.BuffTimeLeft,
                TargetBuffTimeLeft = spell.TargetBuffTimeLeft,
                HaveBuff = spell.HaveBuff,
                TargetHaveBuff = spell.TargetHaveBuff
            };
        }

        public uint Id { set; get; }
        public bool KnownSpell { set; get; }
        public float CastTime { set; get; }
        public string Icon { set; get; }
        public float MinRange { set; get; }
        public string Name { set; get; }
        public string NameInGame { set; get; }
        public string SubName { set; get; }
        public float MaxRange { set; get; }
        public bool IsSpellUsable { get; set; }
        public bool IsInActionBar { get; set; }
        public bool IsDistanceGood { get; set; }
        public int BuffStack { get; set; }
        public int TargetBuffStack { get; set; }
        public int BuffTimeLeft { get; set; }
        public int TargetBuffTimeLeft { get; set; }
        public bool HaveBuff { get; set; }
        public bool TargetHaveBuff { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using robotManager.Helpful;
using wManager.Wow.Enums;

namespace DataLoggingPlugin.Shim
{
    class Npc
    {
        public static Npc Map(wManager.Wow.Class.Npc npc)
        {
            return new Npc
            {
                Entry = npc.Entry,
                Name = npc.Name,
                GossipOption = npc.GossipOption,
                CurrentProfileNpc = npc.CurrentProfileNpc,
                Active = npc.Active,
                Faction = npc.Faction,
                Type = npc.Type,
                ContinentId = npc.ContinentId,
                Position = npc.Position
            };
        }

        public Vector3 Position { get; set; }
        public int Entry { get; set; }
        public string Name { get; set; }
        public int GossipOption { get; set; }
        public bool CurrentProfileNpc { get; set; }
        public bool Active { get; set; }
        public wManager.Wow.Class.Npc.FactionType Faction { get; set; }
        public wManager.Wow.Class.Npc.NpcType Type { get; set; }
        public ContinentId ContinentId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using robotManager.Helpful;
using wManager.Wow.Enums;
using wManager.Wow.ObjectManager;

namespace DataLoggingPlugin.Shim
{
    class Corpse
    {
        public static Corpse Map(WoWCorpse corpse)
        {
            return new Corpse
            {
                Guid = corpse.Guid,
                Type = corpse.Type,
                Entry = corpse.Entry,
                Scale = corpse.Scale,
                Position = corpse.Position,
                Name = corpse.Name,
                GetDistance = corpse.GetDistance,
            };
        }

        public ulong Guid { get; set; }
        public WoWObjectType Type { get; set; }
        public int Entry { get; set; }
        public float Scale { get; set; }
        public Vector3 Position { get; set; }
        public string Name { get; set; }
        public float GetDistance { get; set; }
    }
}

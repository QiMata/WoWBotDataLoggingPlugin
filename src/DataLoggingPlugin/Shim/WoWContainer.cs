using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using wManager.Wow.Enums;

namespace DataLoggingPlugin.Shim
{
    class WoWContainer
    {
        public static WoWContainer Map(wManager.Wow.ObjectManager.WoWContainer container)
        {
            return new WoWContainer
            {
                NumberSlot = container.NumberSlot,
                Name = container.Name,
                GetItemInfo = ItemInfo.Map(container.GetItemInfo),
                StackCount = container.StackCount,
                Durability = container.Durability,
                MaxDurability = container.MaxDurability,
                Owner = container.Owner,
                ContainedIn = container.ContainedIn,
                InBag = container.InBag,
                Guid = container.Guid,
                Type = container.Type
            };
        }

        public int NumberSlot { get; set; }
        public string Name { get; set; }
        public ItemInfo GetItemInfo { get; set; }
        public int StackCount { get; set; }
        public int Durability { get; set; }
        public int MaxDurability { get; set; }
        public ulong Owner { get; set; }
        public ulong ContainedIn { get; set; }
        public bool InBag { get; set; }

        public ulong Guid { get; set; }
        public WoWObjectType Type { get; set; }
    }
}

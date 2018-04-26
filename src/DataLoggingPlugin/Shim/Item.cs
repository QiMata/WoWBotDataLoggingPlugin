using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using wManager.Wow.ObjectManager;

namespace DataLoggingPlugin.Shim
{
    class Item
    {
        public static Item Map(WoWItem item)
        {
            return new Item
            {
                Name = item.Name,
                GetItemInfo = ItemInfo.Map(item.GetItemInfo),
                StackCount = item.StackCount,
                Durability = item.Durability,
                MaxDurability = item.MaxDurability,
                Owner = item.Owner,
                ContainedIn = item.ContainedIn,
                InBag = item.InBag,
            };
        }

        public string Name { get; set; }
        public ItemInfo GetItemInfo { get; set; }
        public int StackCount { get; set; }
        public int Durability { get; set; }
        public int MaxDurability { get; set; }
        public ulong Owner { get; set; }
        public ulong ContainedIn { get; set; }
        public bool InBag { get; set; }
    }
}

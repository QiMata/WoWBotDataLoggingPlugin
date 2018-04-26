namespace DataLoggingPlugin.Shim
{
    public class ItemInfo
    {
        public static ItemInfo Map(wManager.Wow.Class.ItemInfo info)
        {
            return new ItemInfo
            {
                ItemEquipLoc = info.ItemEquipLoc,
                ItemLevel = info.ItemLevel,
                ItemLink = info.ItemLink,
                ItemMinLevel = info.ItemMinLevel,
                ItemName = info.ItemName,
                ItemRarity = info.ItemRarity,
                ItemSellPrice = info.ItemSellPrice,
                ItemStackCount = info.ItemStackCount,
                ItemSubType = info.ItemSubType,
                ItemTexture = info.ItemTexture,
                ItemType = info.ItemType
            };
        }

        public string ItemEquipLoc { get; set; }
        public int ItemLevel { get; set; }
        public string ItemLink { get; set; }
        public int ItemMinLevel { get; set; }
        public string ItemName { get; set; }
        public int ItemRarity { get; set; }
        public int ItemSellPrice { get; set; }
        public int ItemStackCount { get; set; }
        public string ItemSubType { get; set; }
        public string ItemTexture { get; set; }
        public string ItemType { get; set; }
    }
}
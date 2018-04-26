using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using robotManager.Helpful;
using wManager.Wow.Enums;
using wManager.Wow.ObjectManager;

namespace DataLoggingPlugin.Shim
{
    class GameObject
    {
        public static GameObject Map(WoWGameObject gameObject)
        {
            return new GameObject
            {
                CreatedBy = gameObject.CreatedBy,
                DisplayId = gameObject.DisplayId,
                FlagsInt = gameObject.FlagsInt,
                Flags = gameObject.Flags,
                Position = gameObject.Position,
                Name = gameObject.Name,
                GetDistance = gameObject.GetDistance,
                GetDistance2D = gameObject.GetDistance2D,
                Data0 = gameObject.Data0,
                Data1 = gameObject.Data1,
                Data8 = gameObject.Data8,
                GOType = gameObject.GOType,
                IsMailbox = gameObject.IsMailbox,
                LockEntry = gameObject.LockEntry,
                CanOpen = gameObject.CanOpen,
                SkillLineRequired = gameObject.SkillLineRequired,
                IsOutdoors = gameObject.IsOutdoors,
                IsIndoors = gameObject.IsIndoors,
                Guid = gameObject.Guid,
                Type = gameObject.Type,
            };
        }

        public ulong CreatedBy { get; set; }
        public int DisplayId { get; set; }
        public int FlagsInt { get; set; }
        public GameObjectFlags Flags { get; set; }
        public Vector3 Position { get; set; }
        public string Name { get; set; }
        public float GetDistance { get; set; }
        public float GetDistance2D { get; set; }
        public uint Data0 { get; set; }
        public uint Data1 { get; set; }
        public uint Data8 { get; set; }
        public WoWGameObjectType GOType { get; set; }
        public bool IsMailbox { get; set; }
        public uint LockEntry { get; set; }
        public bool CanOpen { get; set; }
        public SkillLine SkillLineRequired { get; set; }
        public bool IsOutdoors { get; set; }
        public bool IsIndoors { get; set; }
        public ulong Guid { get; set; }
        public WoWObjectType Type { get; set; }
    }
}

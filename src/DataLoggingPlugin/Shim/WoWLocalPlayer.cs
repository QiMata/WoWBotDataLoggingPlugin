using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using robotManager.Helpful;
using wManager.Wow.Class;
using wManager.Wow.Enums;
using wManager.Wow.Helpers;
using wManager.Wow.ObjectManager;

namespace DataLoggingPlugin.Shim
{
    class WoWLocalPlayer
    {
        public static WoWLocalPlayer Map(wManager.Wow.ObjectManager.WoWLocalPlayer player, bool mapTarget = true, int depth = 0)
        {
            return new WoWLocalPlayer
            {
                Name = player.Name,
                MeCreatureTrack = player.MeCreatureTrack,
                MeObjectTrack = player.MeObjectTrack,
                IsCast = player.IsCast,
                GetDurabilityPercent = player.GetDurabilityPercent,
                Experience = player.Experience,
                ExperienceMax = player.ExperienceMax,
                LevelDecimal = player.LevelDecimal,
                PositionCorpse = player.PositionCorpse,
                IsDead = player.IsDead,
                IsDeadMe = player.IsDeadMe,
                InCombat = player.InCombat,
                InvSlots = player.InvSlots,
                IsMounted = player.IsMounted,
                MapPositionLua = player.MapPositionLua,
                GetMoneyCopper = player.GetMoneyCopper,
                Gender = player.Gender,
                GetHonorPoint = player.GetHonorPoint,
                PlayerUsingVehicle = player.PlayerUsingVehicle,
                IsInPetBattle = player.IsInPetBattle,
                IsPartyMember = player.IsPartyMember,
                IsInParty = player.IsInParty,
                IsInGroup = player.IsInGroup,
                GlobalCooldownEnabled = player.GlobalCooldownEnabled,
                GlobalCooldownTimeLeft = player.GlobalCooldownTimeLeft,
                CastingTimeLeft = player.CastingTimeLeft,
                BreathTimerLeft = player.BreathTimerLeft,
                BreathActive = player.BreathActive,
                FatigueTimerLeft = player.FatigueTimerLeft,
                FatigueActive = player.FatigueActive,
                HasNewMail = player.HasNewMail,
                PlayerFaction = player.PlayerFaction,
                IsHorde = player.IsHorde,
                IsAlliance = player.IsAlliance,
                IsNeutral = player.IsNeutral,
                PlayerRace = player.PlayerRace,
                PlayerRaceString = player.PlayerRaceString,
                BarTwo = player.BarTwo,
                BarTwoMax = player.BarTwoMax,
                PowerType = player.PowerType,
                BarTwoPercentage = player.BarTwoPercentage,
                ComboPoint = player.ComboPoint,
                IsSitting = player.IsSitting,
                WowClass = player.WowClass,
                IsLocalPlayer = player.IsLocalPlayer,
                PositionWithoutType = player.PositionWithoutType,
                PositionRelativeWithoutType = player.PositionRelativeWithoutType,
                Health = player.Health,
                MaxHealth = player.MaxHealth,
                MyCharacterInFrontHim = player.MyCharacterInFrontHim,
                HealthPercent = player.HealthPercent,
                HealthRatio = player.HealthRatio,
                IsGoodInteractDistance = player.IsGoodInteractDistance,
                InteractDistance = player.InteractDistance,
                CombatReach = player.CombatReach,
                IsSwimming = player.IsSwimming,
                IsMovingForward = player.IsMovingForward,
                IsMovingBackwards = player.IsMovingBackwards,
                IsStrafingLeft = player.IsStrafingLeft,
                IsStrafingRight = player.IsStrafingRight,
                IsTurningLeft = player.IsTurningLeft,
                IsTurningRight = player.IsTurningRight,
                IsFlying = player.IsFlying,
                IsStunned = player.IsStunned,
                AggroDistance = player.AggroDistance,
                Rotation = player.Rotation,
                CreatureTypeTarget = player.CreatureTypeTarget,
                Mana = player.Mana,
                MaxMana = player.MaxMana,
                ManaPercentage = player.ManaPercentage,
                Rage = player.Rage,
                MaxRage = player.MaxRage,
                RagePercentage = player.RagePercentage,
                Focus = player.Focus,
                MaxFocus = player.MaxFocus,
                FocusPercentage = player.FocusPercentage,
                Energy = player.Energy,
                MaxEnergy = player.MaxEnergy,
                EnergyPercentage = player.EnergyPercentage,
                Chi = player.Chi,
                MaxChi = player.MaxChi,
                ChiPercentage = player.ChiPercentage,
                MaxRunes = player.MaxRunes,
                RunesPercentage = player.RunesPercentage,
                RunicPower = player.RunicPower,
                MaxRunicPower = player.MaxRunicPower,
                RunicPowerPercentage = player.RunicPowerPercentage,
                SoulShards = player.SoulShards,
                MaxSoulShards = player.MaxSoulShards,
                SoulShardsPercentage = player.SoulShardsPercentage,
                UnitClassification = player.UnitClassification,
                IsElite = player.IsElite,
                IsWorldBoss = player.IsWorldBoss,
                HolyPower = player.HolyPower,
                MaxHolyPower = player.MaxHolyPower,
                HolyPowerPercentage = player.HolyPowerPercentage,
                Alternate = player.Alternate,
                MaxAlternate = player.MaxAlternate,
                AlternatePercentage = player.AlternatePercentage,
                DarkForce = player.DarkForce,
                MaxDarkForce = player.MaxDarkForce,
                DarkForcePercentage = player.DarkForcePercentage,
                LightForce = player.LightForce,
                MaxLightForce = player.MaxLightForce,
                LightForcePercentage = player.LightForcePercentage,
                ShadowOrbs = player.ShadowOrbs,
                MaxShadowOrbs = player.MaxShadowOrbs,
                ShadowOrbsPercentage = player.ShadowOrbsPercentage,
                BurningEmbers = player.BurningEmbers,
                MaxBurningEmbers = player.MaxBurningEmbers,
                BurningEmbersPercentage = player.BurningEmbersPercentage,
                DemonicFury = player.DemonicFury,
                MaxDemonicFury = player.MaxDemonicFury,
                DemonicFuryPercentage = player.DemonicFuryPercentage,
                ArcaneCharges = player.ArcaneCharges,
                MaxArcaneCharges = player.MaxArcaneCharges,
                ArcaneChargesPercentage = player.ArcaneChargesPercentage,
                Faction = player.Faction,
                DisplayId = player.DisplayId,
                GetMove = player.GetMove,
                GetMoveFlag = player.GetMoveFlag,
                SpeedMoving = player.SpeedMoving,
                GetDistance2D = player.GetDistance2D,
                GetDistanceZ = player.GetDistanceZ,
                IsAlive = player.IsAlive,
                IsLootable = player.IsLootable,
                IsTaggedByOther = player.IsTaggedByOther,
                TaggedByMe = player.TaggedByMe,
                IsTapDenied = player.IsTapDenied,
                IsMyPet = player.IsMyPet,
                HasTarget = player.HasTarget,
                IsTargetingMe = player.IsTargetingMe,
                IsTargetingMyPet = player.IsTargetingMyPet,
                IsTargetingPartyMember = player.IsTargetingPartyMember,
                IsTargetingMeOrMyPet = player.IsTargetingMeOrMyPet,
                IsTargetingMeOrMyPetOrPartyMember = player.IsTargetingMeOrMyPetOrPartyMember,
                IsMyTarget = player.IsMyTarget,
                IsMyPetTarget = player.IsMyPetTarget,
                IsPartyMemberTarget = player.IsPartyMemberTarget,
                IsMeOrMyPetTarget = player.IsMeOrMyPetTarget,
                IsMeOrMyPetOrPartyMemberTarget = player.IsMeOrMyPetOrPartyMemberTarget,
                Target = player.Target,
                Level = player.Level,
                IsBoss = player.IsBoss,
                PetNumber = player.PetNumber,
                DBCacheRow = player.DBCacheRow,
                UnitFlags = player.UnitFlags,
                UnitNPCFlags = player.UnitNPCFlags,
                Skinnable = player.Skinnable,
                IsNpcSpiritHealer = player.IsNpcSpiritHealer,
                IsNpcRepair = player.IsNpcRepair,
                IsNpcVendor = player.IsNpcVendor,
                IsFlightMaster = player.IsFlightMaster,
                IsNpcInnkeeper = player.IsNpcInnkeeper,
                IsAuctioneer = player.IsAuctioneer,
                IsNpcTrainer = player.IsNpcTrainer,
                IsNpcWildPets = player.IsNpcWildPets,
                Summon = player.Summon,
                CreatedBy = player.CreatedBy,
                CreatedBySpell = player.CreatedBySpell,
                SummonedBy = player.SummonedBy,
                IsPet = player.IsPet,
                PetOwnerGuid = player.PetOwnerGuid,
                InCombatFlagOnly = player.InCombatFlagOnly,
                InCombatWithMe = player.InCombatWithMe,
                CastingSpellId = player.CastingSpellId,
                MountDisplayId = player.MountDisplayId,
                TransportGuid = player.TransportGuid,
                InTransport = player.InTransport,
                Reaction = player.Reaction,
                IsTracked = player.IsTracked,
                IsOnTaxi = player.IsOnTaxi,
                NotSelectable = player.NotSelectable,
                IsAttackable = player.IsAttackable,
                PlayerControlled = player.PlayerControlled,
                Silenced = player.Silenced,
                Rooted = player.Rooted,
                Influenced = player.Influenced,
                Confused = player.Confused,
                Pacified = player.Pacified,
                Fleeing = player.Fleeing,
                Possessed = player.Possessed,
                NpcMarkerId = player.NpcMarkerId,
                NpcFlightMastrerIsDiscover = player.NpcFlightMastrerIsDiscover,
                NpcMarker = player.NpcMarker,
                IsOutdoors = player.IsOutdoors,
                IsIndoors = player.IsIndoors,
                IsPartyLeader = player.IsPartyLeader,
                Runes = player.Runes,
                TargetObject = TargetConvert(player, mapTarget, depth),
                Guid = player.Guid,
                Type = player.Type
            };
        }

        public static WoWLocalPlayer Map(wManager.Wow.ObjectManager.WoWPlayer player, bool mapTarget = true, int depth = 0)
        {
            return new WoWLocalPlayer
            {
                Name = player.Name,
                IsCast = player.IsCast,
                IsDead = player.IsDead,
                InCombat = player.InCombat,
                IsMounted = player.IsMounted,
                IsPartyMember = player.IsPartyMember,
                PlayerFaction = player.PlayerFaction,
                IsHorde = player.IsHorde,
                IsAlliance = player.IsAlliance,
                IsNeutral = player.IsNeutral,
                PlayerRace = player.PlayerRace,
                PlayerRaceString = player.PlayerRaceString,
                BarTwo = player.BarTwo,
                BarTwoMax = player.BarTwoMax,
                PowerType = player.PowerType,
                BarTwoPercentage = player.BarTwoPercentage,
                ComboPoint = player.ComboPoint,
                IsSitting = player.IsSitting,
                WowClass = player.WowClass,
                IsLocalPlayer = player.IsLocalPlayer,
                PositionWithoutType = player.PositionWithoutType,
                PositionRelativeWithoutType = player.PositionRelativeWithoutType,
                Health = player.Health,
                MaxHealth = player.MaxHealth,
                MyCharacterInFrontHim = player.MyCharacterInFrontHim,
                HealthPercent = player.HealthPercent,
                HealthRatio = player.HealthRatio,
                IsGoodInteractDistance = player.IsGoodInteractDistance,
                InteractDistance = player.InteractDistance,
                CombatReach = player.CombatReach,
                IsSwimming = player.IsSwimming,
                IsMovingForward = player.IsMovingForward,
                IsMovingBackwards = player.IsMovingBackwards,
                IsStrafingLeft = player.IsStrafingLeft,
                IsStrafingRight = player.IsStrafingRight,
                IsTurningLeft = player.IsTurningLeft,
                IsTurningRight = player.IsTurningRight,
                IsFlying = player.IsFlying,
                IsStunned = player.IsStunned,
                AggroDistance = player.AggroDistance,
                Rotation = player.Rotation,
                CreatureTypeTarget = player.CreatureTypeTarget,
                Mana = player.Mana,
                MaxMana = player.MaxMana,
                ManaPercentage = player.ManaPercentage,
                Rage = player.Rage,
                MaxRage = player.MaxRage,
                RagePercentage = player.RagePercentage,
                Focus = player.Focus,
                MaxFocus = player.MaxFocus,
                FocusPercentage = player.FocusPercentage,
                Energy = player.Energy,
                MaxEnergy = player.MaxEnergy,
                EnergyPercentage = player.EnergyPercentage,
                Chi = player.Chi,
                MaxChi = player.MaxChi,
                ChiPercentage = player.ChiPercentage,
                MaxRunes = player.MaxRunes,
                RunesPercentage = player.RunesPercentage,
                RunicPower = player.RunicPower,
                MaxRunicPower = player.MaxRunicPower,
                RunicPowerPercentage = player.RunicPowerPercentage,
                SoulShards = player.SoulShards,
                MaxSoulShards = player.MaxSoulShards,
                SoulShardsPercentage = player.SoulShardsPercentage,
                UnitClassification = player.UnitClassification,
                IsElite = player.IsElite,
                IsWorldBoss = player.IsWorldBoss,
                HolyPower = player.HolyPower,
                MaxHolyPower = player.MaxHolyPower,
                HolyPowerPercentage = player.HolyPowerPercentage,
                Alternate = player.Alternate,
                MaxAlternate = player.MaxAlternate,
                AlternatePercentage = player.AlternatePercentage,
                DarkForce = player.DarkForce,
                MaxDarkForce = player.MaxDarkForce,
                DarkForcePercentage = player.DarkForcePercentage,
                LightForce = player.LightForce,
                MaxLightForce = player.MaxLightForce,
                LightForcePercentage = player.LightForcePercentage,
                ShadowOrbs = player.ShadowOrbs,
                MaxShadowOrbs = player.MaxShadowOrbs,
                ShadowOrbsPercentage = player.ShadowOrbsPercentage,
                BurningEmbers = player.BurningEmbers,
                MaxBurningEmbers = player.MaxBurningEmbers,
                BurningEmbersPercentage = player.BurningEmbersPercentage,
                DemonicFury = player.DemonicFury,
                MaxDemonicFury = player.MaxDemonicFury,
                DemonicFuryPercentage = player.DemonicFuryPercentage,
                ArcaneCharges = player.ArcaneCharges,
                MaxArcaneCharges = player.MaxArcaneCharges,
                ArcaneChargesPercentage = player.ArcaneChargesPercentage,
                Faction = player.Faction,
                DisplayId = player.DisplayId,
                GetMove = player.GetMove,
                GetMoveFlag = player.GetMoveFlag,
                SpeedMoving = player.SpeedMoving,
                GetDistance2D = player.GetDistance2D,
                GetDistanceZ = player.GetDistanceZ,
                IsAlive = player.IsAlive,
                IsLootable = player.IsLootable,
                IsTaggedByOther = player.IsTaggedByOther,
                TaggedByMe = player.TaggedByMe,
                IsTapDenied = player.IsTapDenied,
                IsMyPet = player.IsMyPet,
                HasTarget = player.HasTarget,
                IsTargetingMe = player.IsTargetingMe,
                IsTargetingMyPet = player.IsTargetingMyPet,
                IsTargetingPartyMember = player.IsTargetingPartyMember,
                IsTargetingMeOrMyPet = player.IsTargetingMeOrMyPet,
                IsTargetingMeOrMyPetOrPartyMember = player.IsTargetingMeOrMyPetOrPartyMember,
                IsMyTarget = player.IsMyTarget,
                IsMyPetTarget = player.IsMyPetTarget,
                IsPartyMemberTarget = player.IsPartyMemberTarget,
                IsMeOrMyPetTarget = player.IsMeOrMyPetTarget,
                IsMeOrMyPetOrPartyMemberTarget = player.IsMeOrMyPetOrPartyMemberTarget,
                Target = player.Target,
                Level = player.Level,
                IsBoss = player.IsBoss,
                PetNumber = player.PetNumber,
                DBCacheRow = player.DBCacheRow,
                UnitFlags = player.UnitFlags,
                UnitNPCFlags = player.UnitNPCFlags,
                Skinnable = player.Skinnable,
                IsNpcSpiritHealer = player.IsNpcSpiritHealer,
                IsNpcRepair = player.IsNpcRepair,
                IsNpcVendor = player.IsNpcVendor,
                IsFlightMaster = player.IsFlightMaster,
                IsNpcInnkeeper = player.IsNpcInnkeeper,
                IsAuctioneer = player.IsAuctioneer,
                IsNpcTrainer = player.IsNpcTrainer,
                IsNpcWildPets = player.IsNpcWildPets,
                Summon = player.Summon,
                CreatedBy = player.CreatedBy,
                CreatedBySpell = player.CreatedBySpell,
                SummonedBy = player.SummonedBy,
                IsPet = player.IsPet,
                PetOwnerGuid = player.PetOwnerGuid,
                InCombatFlagOnly = player.InCombatFlagOnly,
                InCombatWithMe = player.InCombatWithMe,
                CastingSpellId = player.CastingSpellId,
                MountDisplayId = player.MountDisplayId,
                TransportGuid = player.TransportGuid,
                InTransport = player.InTransport,
                Reaction = player.Reaction,
                IsTracked = player.IsTracked,
                IsOnTaxi = player.IsOnTaxi,
                NotSelectable = player.NotSelectable,
                IsAttackable = player.IsAttackable,
                PlayerControlled = player.PlayerControlled,
                Silenced = player.Silenced,
                Rooted = player.Rooted,
                Influenced = player.Influenced,
                Confused = player.Confused,
                Pacified = player.Pacified,
                Fleeing = player.Fleeing,
                Possessed = player.Possessed,
                NpcMarkerId = player.NpcMarkerId,
                NpcFlightMastrerIsDiscover = player.NpcFlightMastrerIsDiscover,
                NpcMarker = player.NpcMarker,
                IsOutdoors = player.IsOutdoors,
                IsIndoors = player.IsIndoors,
                IsPartyLeader = player.IsPartyLeader,
                Runes = player.Runes,
                TargetObject = TargetConvert(player, mapTarget, depth),
                Guid = player.Guid,
                Type = player.Type
            };
        }

        private static WoWLocalPlayer TargetConvert(wManager.Wow.ObjectManager.WoWLocalPlayer player, bool mapTarget, int depth)
        {
            return mapTarget && depth < 1 ? Map(player.TargetObject,player.IsTargetingMe,depth++) : null;
        }

        private static WoWLocalPlayer TargetConvert(wManager.Wow.ObjectManager.WoWPlayer player, bool mapTarget, int depth)
        {
            if (player.TargetObject is wManager.Wow.ObjectManager.WoWLocalPlayer localPlayer)
            {
                return mapTarget && depth < 1 ? Map(localPlayer, player.IsTargetingMe, depth++) : null;
            }

            return mapTarget && depth < 1 ? Map(player.TargetObject, player.IsTargetingMe, depth++) : null;
        }

        private static WoWLocalPlayer TargetConvert(WoWUnit player, bool mapTarget, int depth)
        {
            if (player.TargetObject is wManager.Wow.ObjectManager.WoWLocalPlayer localPlayer)
            {
                return mapTarget && depth < 1 ? Map(localPlayer, player.IsTargetingMe, depth++) : null;
            }
            else if (player.TargetObject is wManager.Wow.ObjectManager.WoWPlayer wowPlayer)
            {
                return mapTarget && depth < 1 ? Map(wowPlayer, player.IsTargetingMe, depth++) : null;
            }

            return mapTarget && depth < 1 ? Map(player.TargetObject, player.IsTargetingMe, depth++) : null;
        }

        public static WoWLocalPlayer Map(WoWUnit player, bool mapTarget = true, int depth = 0)
        {
            return new WoWLocalPlayer
            {
                Name = player.Name,
                IsCast = player.IsCast,
                IsDead = player.IsDead,
                InCombat = player.InCombat,
                IsMounted = player.IsMounted,
                IsPartyMember = player.IsPartyMember,
                WowClass = player.WowClass,
                IsLocalPlayer = player.IsLocalPlayer,
                PositionWithoutType = player.PositionWithoutType,
                PositionRelativeWithoutType = player.PositionRelativeWithoutType,
                Health = player.Health,
                MaxHealth = player.MaxHealth,
                MyCharacterInFrontHim = player.MyCharacterInFrontHim,
                HealthPercent = player.HealthPercent,
                HealthRatio = player.HealthRatio,
                IsGoodInteractDistance = player.IsGoodInteractDistance,
                InteractDistance = player.InteractDistance,
                CombatReach = player.CombatReach,
                IsSwimming = player.IsSwimming,
                IsMovingForward = player.IsMovingForward,
                IsMovingBackwards = player.IsMovingBackwards,
                IsStrafingLeft = player.IsStrafingLeft,
                IsStrafingRight = player.IsStrafingRight,
                IsTurningLeft = player.IsTurningLeft,
                IsTurningRight = player.IsTurningRight,
                IsFlying = player.IsFlying,
                IsStunned = player.IsStunned,
                AggroDistance = player.AggroDistance,
                Rotation = player.Rotation,
                CreatureTypeTarget = player.CreatureTypeTarget,
                Mana = player.Mana,
                MaxMana = player.MaxMana,
                ManaPercentage = player.ManaPercentage,
                Rage = player.Rage,
                MaxRage = player.MaxRage,
                RagePercentage = player.RagePercentage,
                Focus = player.Focus,
                MaxFocus = player.MaxFocus,
                FocusPercentage = player.FocusPercentage,
                Energy = player.Energy,
                MaxEnergy = player.MaxEnergy,
                EnergyPercentage = player.EnergyPercentage,
                Chi = player.Chi,
                MaxChi = player.MaxChi,
                ChiPercentage = player.ChiPercentage,
                MaxRunes = player.MaxRunes,
                RunesPercentage = player.RunesPercentage,
                RunicPower = player.RunicPower,
                MaxRunicPower = player.MaxRunicPower,
                RunicPowerPercentage = player.RunicPowerPercentage,
                SoulShards = player.SoulShards,
                MaxSoulShards = player.MaxSoulShards,
                SoulShardsPercentage = player.SoulShardsPercentage,
                UnitClassification = player.UnitClassification,
                IsElite = player.IsElite,
                IsWorldBoss = player.IsWorldBoss,
                HolyPower = player.HolyPower,
                MaxHolyPower = player.MaxHolyPower,
                HolyPowerPercentage = player.HolyPowerPercentage,
                Alternate = player.Alternate,
                MaxAlternate = player.MaxAlternate,
                AlternatePercentage = player.AlternatePercentage,
                DarkForce = player.DarkForce,
                MaxDarkForce = player.MaxDarkForce,
                DarkForcePercentage = player.DarkForcePercentage,
                LightForce = player.LightForce,
                MaxLightForce = player.MaxLightForce,
                LightForcePercentage = player.LightForcePercentage,
                ShadowOrbs = player.ShadowOrbs,
                MaxShadowOrbs = player.MaxShadowOrbs,
                ShadowOrbsPercentage = player.ShadowOrbsPercentage,
                BurningEmbers = player.BurningEmbers,
                MaxBurningEmbers = player.MaxBurningEmbers,
                BurningEmbersPercentage = player.BurningEmbersPercentage,
                DemonicFury = player.DemonicFury,
                MaxDemonicFury = player.MaxDemonicFury,
                DemonicFuryPercentage = player.DemonicFuryPercentage,
                ArcaneCharges = player.ArcaneCharges,
                MaxArcaneCharges = player.MaxArcaneCharges,
                ArcaneChargesPercentage = player.ArcaneChargesPercentage,
                Faction = player.Faction,
                DisplayId = player.DisplayId,
                GetMove = player.GetMove,
                GetMoveFlag = player.GetMoveFlag,
                SpeedMoving = player.SpeedMoving,
                GetDistance2D = player.GetDistance2D,
                GetDistanceZ = player.GetDistanceZ,
                IsAlive = player.IsAlive,
                IsLootable = player.IsLootable,
                IsTaggedByOther = player.IsTaggedByOther,
                TaggedByMe = player.TaggedByMe,
                IsTapDenied = player.IsTapDenied,
                IsMyPet = player.IsMyPet,
                HasTarget = player.HasTarget,
                IsTargetingMe = player.IsTargetingMe,
                IsTargetingMyPet = player.IsTargetingMyPet,
                IsTargetingPartyMember = player.IsTargetingPartyMember,
                IsTargetingMeOrMyPet = player.IsTargetingMeOrMyPet,
                IsTargetingMeOrMyPetOrPartyMember = player.IsTargetingMeOrMyPetOrPartyMember,
                IsMyTarget = player.IsMyTarget,
                IsMyPetTarget = player.IsMyPetTarget,
                IsPartyMemberTarget = player.IsPartyMemberTarget,
                IsMeOrMyPetTarget = player.IsMeOrMyPetTarget,
                IsMeOrMyPetOrPartyMemberTarget = player.IsMeOrMyPetOrPartyMemberTarget,
                Target = player.Target,
                Level = player.Level,
                IsBoss = player.IsBoss,
                PetNumber = player.PetNumber,
                DBCacheRow = player.DBCacheRow,
                UnitFlags = player.UnitFlags,
                UnitNPCFlags = player.UnitNPCFlags,
                Skinnable = player.Skinnable,
                IsNpcSpiritHealer = player.IsNpcSpiritHealer,
                IsNpcRepair = player.IsNpcRepair,
                IsNpcVendor = player.IsNpcVendor,
                IsFlightMaster = player.IsFlightMaster,
                IsNpcInnkeeper = player.IsNpcInnkeeper,
                IsAuctioneer = player.IsAuctioneer,
                IsNpcTrainer = player.IsNpcTrainer,
                IsNpcWildPets = player.IsNpcWildPets,
                Summon = player.Summon,
                CreatedBy = player.CreatedBy,
                CreatedBySpell = player.CreatedBySpell,
                SummonedBy = player.SummonedBy,
                IsPet = player.IsPet,
                PetOwnerGuid = player.PetOwnerGuid,
                InCombatFlagOnly = player.InCombatFlagOnly,
                InCombatWithMe = player.InCombatWithMe,
                CastingSpellId = player.CastingSpellId,
                MountDisplayId = player.MountDisplayId,
                TransportGuid = player.TransportGuid,
                InTransport = player.InTransport,
                Reaction = player.Reaction,
                IsTracked = player.IsTracked,
                IsOnTaxi = player.IsOnTaxi,
                NotSelectable = player.NotSelectable,
                IsAttackable = player.IsAttackable,
                PlayerControlled = player.PlayerControlled,
                Silenced = player.Silenced,
                Rooted = player.Rooted,
                Influenced = player.Influenced,
                Confused = player.Confused,
                Pacified = player.Pacified,
                Fleeing = player.Fleeing,
                Possessed = player.Possessed,
                NpcMarkerId = player.NpcMarkerId,
                NpcFlightMastrerIsDiscover = player.NpcFlightMastrerIsDiscover,
                NpcMarker = player.NpcMarker,
                IsOutdoors = player.IsOutdoors,
                IsIndoors = player.IsIndoors,
                IsPartyLeader = player.IsPartyLeader,
                Runes = player.Runes,
                TargetObject = TargetConvert(player, mapTarget, depth),
                Guid = player.Guid,
                Type =  player.Type
            };
        }

        public WoWObjectType Type { get; set; }
        public ulong Guid { get; set; }
        public string Name { get; set; }
        public TrackCreatureFlags MeCreatureTrack { get; set; }
        public TrackObjectFlags MeObjectTrack { get; set; }
        public bool IsCast { get; set; }
        public double GetDurabilityPercent { get; set; }
        public int Experience { get; set; }
        public int ExperienceMax { get; set; }
        public double LevelDecimal { get; set; }
        public Vector3 PositionCorpse { get; set; }
        public bool IsDead { get; set; }
        public bool IsDeadMe { get; set; }
        public bool InCombat { get; set; }
        public List<ulong> InvSlots { get; set; }
        public bool IsMounted { get; set; }
        public string[] MapPositionLua { get; set; }
        public long GetMoneyCopper { get; set; }
        public WoWGender Gender { get; set; }
        public int GetHonorPoint { get; set; }
        public bool PlayerUsingVehicle { get; set; }
        public bool IsInPetBattle { get; set; }
        public bool IsPartyMember { get; set; }
        public bool IsInParty { get; set; }
        public bool IsInGroup { get; set; }
        public bool GlobalCooldownEnabled { get; set; }
        public int GlobalCooldownTimeLeft { get; set; }
        public int CastingTimeLeft { get; set; }
        public int BreathTimerLeft { get; set; }
        public bool BreathActive { get; set; }
        public int FatigueTimerLeft { get; set; }
        public bool FatigueActive { get; set; }
        public bool HasNewMail { get; set; }
        public string PlayerFaction { get; set; }
        public bool IsHorde { get; set; }
        public bool IsAlliance { get; set; }
        public bool IsNeutral { get; set; }
        public PlayerFactions PlayerRace { get; set; }
        public string PlayerRaceString { get; set; }
        public uint BarTwo { get; set; }
        public uint BarTwoMax { get; set; }
        public PowerType PowerType { get; set; }
        public uint BarTwoPercentage { get; set; }
        public int ComboPoint { get; set; }
        public bool IsSitting { get; set; }
        public WoWClass WowClass { get; set; }
        public bool IsLocalPlayer { get; set; }
        public Vector3 PositionWithoutType { get; set; }
        public Vector3 PositionRelativeWithoutType { get; set; }
        public long Health { get; set; }
        public long MaxHealth { get; set; }
        public bool MyCharacterInFrontHim { get; set; }
        public double HealthPercent { get; set; }
        public double HealthRatio { get; set; }
        public bool IsGoodInteractDistance { get; set; }
        public float InteractDistance { get; set; }
        public float CombatReach { get; set; }
        public bool IsSwimming { get; set; }
        public bool IsMovingForward { get; set; }
        public bool IsMovingBackwards { get; set; }
        public bool IsStrafingLeft { get; set; }
        public bool IsStrafingRight { get; set; }
        public bool IsTurningLeft { get; set; }
        public bool IsTurningRight { get; set; }
        public bool IsFlying { get; set; }
        public bool IsStunned { get; set; }
        public int AggroDistance { get; set; }
        public float Rotation { get; set; }
        public string CreatureTypeTarget { get; set; }
        public uint Mana { get; set; }
        public uint MaxMana { get; set; }
        public uint ManaPercentage { get; set; }
        public uint Rage { get; set; }
        public uint MaxRage { get; set; }
        public uint RagePercentage { get; set; }
        public uint Focus { get; set; }
        public uint MaxFocus { get; set; }
        public uint FocusPercentage { get; set; }
        public uint Energy { get; set; }
        public uint MaxEnergy { get; set; }
        public uint EnergyPercentage { get; set; }
        public uint Chi { get; set; }
        public uint MaxChi { get; set; }
        public uint ChiPercentage { get; set; }
        public uint Runes { get; set; }
        public uint MaxRunes { get; set; }
        public uint RunesPercentage { get; set; }
        public uint RunicPower { get; set; }
        public uint MaxRunicPower { get; set; }
        public uint RunicPowerPercentage { get; set; }
        public uint SoulShards { get; set; }
        public uint MaxSoulShards { get; set; }
        public uint SoulShardsPercentage { get; set; }
        public UnitClassification UnitClassification { get; set; }
        public bool IsElite { get; set; }
        public bool IsWorldBoss { get; set; }
        public uint HolyPower { get; set; }
        public uint MaxHolyPower { get; set; }
        public uint HolyPowerPercentage { get; set; }
        public uint Alternate { get; set; }
        public uint MaxAlternate { get; set; }
        public uint AlternatePercentage { get; set; }
        public uint DarkForce { get; set; }
        public uint MaxDarkForce { get; set; }
        public uint DarkForcePercentage { get; set; }
        public uint LightForce { get; set; }
        public uint MaxLightForce { get; set; }
        public uint LightForcePercentage { get; set; }
        public uint ShadowOrbs { get; set; }
        public uint MaxShadowOrbs { get; set; }
        public uint ShadowOrbsPercentage { get; set; }
        public uint BurningEmbers { get; set; }
        public uint MaxBurningEmbers { get; set; }
        public uint BurningEmbersPercentage { get; set; }
        public uint DemonicFury { get; set; }
        public uint MaxDemonicFury { get; set; }
        public uint DemonicFuryPercentage { get; set; }
        public uint ArcaneCharges { get; set; }
        public uint MaxArcaneCharges { get; set; }
        public uint ArcaneChargesPercentage { get; set; }
        public uint Faction { get; set; }
        public uint DisplayId { get; set; }
        public bool GetMove { get; set; }
        public int GetMoveFlag { get; set; }
        public float SpeedMoving { get; set; }
        public float GetDistance2D { get; set; }
        public float GetDistanceZ { get; set; }
        public bool IsAlive { get; set; }
        public bool IsLootable { get; set; }
        public bool IsTaggedByOther { get; set; }
        public bool TaggedByMe { get; set; }
        public bool IsTapDenied { get; set; }
        public bool IsMyPet { get; set; }
        public bool HasTarget { get; set; }
        public bool IsTargetingMe { get; set; }
        public bool IsTargetingMyPet { get; set; }
        public bool IsTargetingPartyMember { get; set; }
        public bool IsTargetingMeOrMyPet { get; set; }
        public bool IsTargetingMeOrMyPetOrPartyMember { get; set; }
        public bool IsMyTarget { get; set; }
        public bool IsMyPetTarget { get; set; }
        public bool IsPartyMemberTarget { get; set; }
        public bool IsMeOrMyPetTarget { get; set; }
        public bool IsMeOrMyPetOrPartyMemberTarget { get; set; }
        public ulong Target { get; set; }
        public uint Level { get; set; }
        public bool IsBoss { get; set; }
        public int PetNumber { get; set; }
        public uint DBCacheRow { get; set; }
        public UnitFlags UnitFlags { get; set; }
        public UnitNPCFlags UnitNPCFlags { get; set; }
        public bool Skinnable { get; set; }
        public bool IsNpcSpiritHealer { get; set; }
        public bool IsNpcRepair { get; set; }
        public bool IsNpcVendor { get; set; }
        public bool IsFlightMaster { get; set; }
        public bool IsNpcInnkeeper { get; set; }
        public bool IsAuctioneer { get; set; }
        public bool IsNpcTrainer { get; set; }
        public bool IsNpcWildPets { get; set; }
        public ulong Summon { get; set; }
        public ulong CreatedBy { get; set; }
        public int CreatedBySpell { get; set; }
        public ulong SummonedBy { get; set; }
        public bool IsPet { get; set; }
        public ulong PetOwnerGuid { get; set; }
        public bool InCombatFlagOnly { get; set; }
        public bool InCombatWithMe { get; set; }
        public int CastingSpellId { get; set; }
        public int MountDisplayId { get; set; }
        public ulong TransportGuid { get; set; }
        public bool InTransport { get; set; }
        public Reaction Reaction { get; set; }
        public bool IsTracked { get; set; }
        public bool IsOnTaxi { get; set; }
        public bool NotSelectable { get; set; }
        public bool IsAttackable { get; set; }
        public bool PlayerControlled { get; set; }
        public bool Silenced { get; set; }
        public bool Rooted { get; set; }
        public bool Influenced { get; set; }
        public bool Confused { get; set; }
        public bool Pacified { get; set; }
        public bool Fleeing { get; set; }
        public bool Possessed { get; set; }
        public int NpcMarkerId { get; set; }
        public bool NpcFlightMastrerIsDiscover { get; set; }
        public NpcMarker NpcMarker { get; set; }
        public bool IsOutdoors { get; set; }
        public bool IsIndoors { get; set; }
        public bool IsPartyLeader { get; set; }
        public WoWLocalPlayer TargetObject { get; set; }
    }
}

using robotManager.Helpful;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using DataLoggingPlugin;
using DataLoggingPlugin.Logging;
using DataLoggingPlugin.Logging.IoTHub;
using DataLoggingPlugin.Shim;
using Newtonsoft.Json;
using wManager.Wow;
using wManager.Wow.Enums;
using wManager.Wow.Helpers;
using wManager.Wow.ObjectManager;
using Message = DataLoggingPlugin.Shim.Message;
using Timer = System.Threading.Timer;
using WoWContainer = DataLoggingPlugin.Shim.WoWContainer;
using WoWLocalPlayer = DataLoggingPlugin.Shim.WoWLocalPlayer;


public class Main : wManager.Plugin.IPlugin
{
    private IEventLog _eventLog;
    private Timer _logSelfTimer;
    private Timer _slowerTimer;

    public void Dispose()
    {
        _eventLog?.Dispose();
        _logSelfTimer?.Dispose();

        _eventLog = null;
        _logSelfTimer = null;
    }

    public void Initialize()
    {
        try
        {
            _eventLog = new EventHubLogger("Endpoint=sb://wwowbotuploader.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=tiebfVCjPLv+xuJbyZ+F0FAYM6eBNX62MbtBTIr2vnw=");
        }
        catch (Exception e)
        {
            var ex = e;
            while (ex != null)
            {
                Logging.Write(ex.Message);
                ex = ex.InnerException;
            }
        }


        foreach (var luaEventId in Enum.GetValues(typeof(LuaEventsId)))
        {
            var luaEventsId = (LuaEventsId)luaEventId;
            EventsLua.AttachEventLua(luaEventsId, x => HandledEvent(x, luaEventsId));
        }

        if (_logSelfTimer == null)
        {
            _logSelfTimer = new Timer(x =>
            {
                _eventLog?.Log(new TimeStampedEvent<WoWLocalPlayer>
                {
                    Type = nameof(WoWLocalPlayer),
                    Name = "Me",
                    Record = WoWLocalPlayer.Map(ObjectManager.Me)
                });
                _eventLog?.Log(new TimeStampedEvent<IEnumerable<WoWLocalPlayer>>
                {
                    Type = nameof(WoWUnit),
                    Name = "Nearby Units",
                    Record = ObjectManager.GetObjectWoWUnit().Select(y => WoWLocalPlayer.Map(y))
                });
            }, null, TimeSpan.FromMilliseconds(Usefuls.Latency + 100), TimeSpan.FromMilliseconds(Usefuls.Latency + 100));
        }
        if (_slowerTimer == null)
        {
            _slowerTimer = new Timer(x =>
            {
                _eventLog?.Log(new TimeStampedEvent<IEnumerable<WoWContainer>>
                {
                    Type = nameof(WoWContainer),
                    Name = "Nearby Containers",
                    Record = ObjectManager.GetObjectWoWContainer().Select(WoWContainer.Map)
                });
                _eventLog?.Log(new TimeStampedEvent<IEnumerable<Corpse>>
                {
                    Type = nameof(WoWCorpse),
                    Name = "Nearby Corpses",
                    Record = ObjectManager.GetObjectWoWCorpse().Select(Corpse.Map)
                });
                _eventLog?.Log(new TimeStampedEvent<IEnumerable<GameObject>>
                {
                    Type = nameof(GameObject),
                    Name = "Nearby GameObjects",
                    Record = ObjectManager.GetObjectWoWGameObject().Select(GameObject.Map)
                });
                _eventLog?.Log(new TimeStampedEvent<IEnumerable<Item>>
                {
                    Type = nameof(WoWItem),
                    Name = "Nearby Items",
                    Record = ObjectManager.GetObjectWoWItem().Select(Item.Map)
                });
                _eventLog?.Log(new TimeStampedEvent<IEnumerable<Vector3>>
                {
                    Type = nameof(Vector3),
                    Name = "CurrentPath",
                    Record = MovementManager.CurrentPath
                });
                _eventLog?.Log(new TimeStampedEvent<IEnumerable<Message>>
                {
                    Type = nameof(Message),
                    Name = "Chat",
                    Record = Chat.Messages.Select(Message.Map)
                });
                _eventLog?.Log(new TimeStampedEvent<IEnumerable<Item>>
                {
                    Type = nameof(WoWItem),
                    Name = "Bag",
                    Record = Bag.GetBagItem().Select(Item.Map)
                });
                _eventLog?.Log(new TimeStampedEvent<IEnumerable<Item>>
                {
                    Type = nameof(WoWItem),
                    Name = "Equiped Items",
                    Record = wManager.Wow.Helpers.EquippedItems.GetEquippedItems().Select(Item.Map)
                });
                _eventLog?.Log(new TimeStampedEvent<IEnumerable<WoWLocalPlayer>>
                {
                    Type = nameof(WoWLocalPlayer),
                    Name = "Party",
                    Record = wManager.Wow.Helpers.Party.GetParty().Select(y => WoWLocalPlayer.Map(y))
                });
                _eventLog?.Log(new TimeStampedEvent<IEnumerable<Quest.PlayerQuest>>
                {
                    Type = nameof(Quest.PlayerQuest),
                    Name = "Quest Log",
                    Record = wManager.Wow.Helpers.Quest.GetLogQuestId()
                });
                _eventLog?.Log(new TimeStampedEvent<IEnumerable<Int32>>
                {
                    Type = nameof(Int32),
                    Name = "Finished Quests",
                    Record = wManager.Wow.Helpers.Quest.FinishedQuestSet
                });
                //_eventLog.Log(new TimeStampedEvent
                //{
                //    Type = nameof(Npc),
                //    Name = "Npc Db",
                //    Record = wManager.Wow.Helpers.NpcDB.ListNpc.Select(Npc.Map)
                //});
                _eventLog?.Log(new TimeStampedEvent<IEnumerable<Spell>>
                {
                    Type = nameof(Spell),
                    Name = "Spell Book",
                    Record = wManager.Wow.Helpers.SpellManager.SpellBook().Select(Spell.Map)
                });
            },null,TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(1));
        }
    }

    public void Settings()
    {
    }

    private void HandledEvent(object context, LuaEventsId eventsId)
    {
        try
        {
            _eventLog?.Log(new TimeStampedEvent<object>
            {
                Record = context,
                Type = "LuaEventLog",
                Name = Enum.GetName(typeof(LuaEventsId), eventsId)
            });
        }
        catch (Exception e)
        {
            robotManager.Helpful.Logging.WriteError(e.Message);
        }
    }
}

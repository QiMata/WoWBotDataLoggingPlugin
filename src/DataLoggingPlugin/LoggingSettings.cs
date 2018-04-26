using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using robotManager;
using robotManager.Helpful;
using wManager.Wow.Helpers;
using wManager.Wow.ObjectManager;

namespace DataLoggingPlugin
{
    //class LoggingSettings : Settings
    //{
    //    [Setting]
    //    [Category("Log")]
    //    [DisplayName("File Path")]
    //    [Description("The Path where the log file will reside")]
    //    public string FilePath { get; set; }

    //    public static LoggingSettings CurrentSetting { get; set; }

    //    LoggingSettings()
    //    {
    //        ConfigWinForm(new System.Drawing.Point(400, 400), "FightClass " + Translate.Get("Settings"));
    //    }

    //    public bool Save()
    //    {
    //        try
    //        {
    //            CurrentSetting.FetchFromLua();
    //            return Save(AdviserFilePathAndName("CustomClass-FightClass", ObjectManager.Me.Name + "." + Usefuls.RealmName));
    //        }
    //        catch (Exception e)
    //        {
    //            robotManager.Helpful.Logging.WriteError("FightClassSettings &gt; Save(): " + e);
    //            return false;
    //        }
    //    }

    //    public static bool Load()
    //    {
    //        try
    //        {
    //            if (File.Exists(AdviserFilePathAndName("CustomClass-FightClass", ObjectManager.Me.Name + "." + Usefuls.RealmName)))
    //            {
    //                CurrentSetting = Load<LoggingSettings>(AdviserFilePathAndName("CustomClass-FightClass", ObjectManager.Me.Name + "." + Usefuls.RealmName));
    //                CurrentSetting.PushToLua();
    //                return true;
    //            }
    //            CurrentSetting = new LoggingSettings();

    //        }
    //        catch (Exception e)
    //        {
    //            robotManager.Helpful.Logging.WriteError("FightClassSettings &gt; Load(): " + e);
    //        }
    //        return false;
    //    }

    //    void FetchFromLua()
    //    {
    //        FilePath = Lua.LuaDoString<string>("return FilePath");
    //    }

    //    void PushToLua()
    //    {
    //        Lua.LuaDoString("TeamRole = " + FilePath);
    //    }
    //}
}

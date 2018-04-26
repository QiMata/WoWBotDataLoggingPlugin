using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using wManager.Wow.Enums;
using wManager.Wow.Helpers;

namespace DataLoggingPlugin.Shim
{
    class Message
    {
        public static Message Map(Channel.Message message)
        {
            return new Message
            {
                DateTime = message.DateTime,
                Channel = message.Channel,
                Msg = message.Msg,
                UserName = message.UserName
            };
        }

        public string DateTime { get; set; }
        public ChatTypeId Channel { get; set; }
        public string Msg { get; set; }
        public string UserName { get; set; }
    }
}

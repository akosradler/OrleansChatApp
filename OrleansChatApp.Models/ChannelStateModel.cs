using System;
using System.Collections.Immutable;
using System.Text;

namespace OrleansChatApp.Models
{
    public class ChannelStateModel
    {
        public ImmutableList<ChatMessage> Messages { get; set; }
    }
}

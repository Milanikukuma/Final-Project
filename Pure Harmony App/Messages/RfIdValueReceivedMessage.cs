using CommunityToolkit.Mvvm.Messaging.Messages;
using Pure_Harmony_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pure_Harmony_App.Messages
{
    public class RfIdValueReceivedMessage : ValueChangedMessage<RfIdTagData>
    {
        public RfIdValueReceivedMessage(RfIdTagData message) : base(message)
        {
        }
    }
}

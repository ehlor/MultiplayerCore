﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteNetLib.Utils;
using MultiplayerCore.Networking.Abstractions;

namespace MultiplayerCore.Players.Packets
{
    internal class PerPlayer : MpPacket
    {
        public bool PPDEnabled;
        public bool PPMEnabled;

        public override void Deserialize(NetDataReader reader)
        {
            PPDEnabled = reader.GetBool();
            PPMEnabled = reader.GetBool();
        }

        public override void Serialize(NetDataWriter writer)
        {
            writer.Put(PPDEnabled);
            writer.Put(PPMEnabled);
        }
    }
}

using System.Collections.Generic;
using Alkahest.Core.Game;

namespace Alkahest.Core.Net.Protocol.Packets
{
    public sealed class CPartyMarkerPacket : Packet
    {
        const string Name = "C_PARTY_MARKER";

        public override string OpCode => Name;

        [Packet(Name)]
        internal static Packet Create()
        {
            return new CPartyMarkerPacket();
        }

        public sealed class PartyMarkerInfo
        {
            [PacketField]
            public PartyMarkerColor Color { get; set; }

            [PacketField]
            public EntityId Target { get; set; }
        }

        [PacketField]
        public List<PartyMarkerInfo> PartyMarkers { get; } =
            new List<PartyMarkerInfo>();
    }
}

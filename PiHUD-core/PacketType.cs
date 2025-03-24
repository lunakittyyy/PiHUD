namespace PiHUD.Core;

public class Packet
{
    public enum PacketType
    {
        C2SRequestStatPulse,
        S2CReturnStatPulse,
        C2SRequestStatOneshot,
        S2CReturnStatOneshot
    }
    public PacketType Type {get; set;}
    public string Content {get; set;}
}
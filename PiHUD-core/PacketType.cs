namespace PiHUD.Core;

public class Packet
{
    public enum PacketType
    {
        C2SAskStats,
        S2CReturnStats,
    }
    public PacketType Type {get; set;}
    public string Content {get; set;}
}
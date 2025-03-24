using PiHUD.Core;
using Newtonsoft.Json;
using WebSocketSharp;
using WebSocketSharp.Server;
using System.Diagnostics;

namespace PiHUD.Server;

class Program
{
    public class PiHudWSServer : WebSocketBehavior
    {
        protected override void OnMessage(MessageEventArgs e)
        {
            var packet = JsonConvert.DeserializeObject<Packet>(e.Data);

            switch (packet!.Type)
            {
                case Packet.PacketType.C2SAskStats:
                    Send(JsonConvert.SerializeObject(new Packet()
                    {
                        Type = Packet.PacketType.S2CReturnStats,
                        Content = JsonConvert.SerializeObject(new StatHeartbeat()
                        {
                            CPUUsage = LinuxStatHelper.GetCPUUsage(),
                            MemoryUsage = LinuxStatHelper.GetMemoryUsage(),
                            Kernel = LinuxStatHelper.Kernel(),
                            Up = LinuxStatHelper.Up(),
                            CpuModel = LinuxStatHelper.CPUModel(),
                            RootUsage = LinuxStatHelper.RootUsage()
                        })
                    }));
                    break;
                default:
                    Console.WriteLine($"I don't know how to handle packet type: {packet.Type}");
                    break;
            }
        }
    }
    
    static void Main(string[] args)
    {
        var wssv = new WebSocketServer ("ws://0.0.0.0:8008");

        wssv.AddWebSocketService<PiHudWSServer> ("/");
        wssv.Start ();
        _ = new ManualResetEvent(false).WaitOne();
    }
}
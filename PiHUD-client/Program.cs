using WebSocketSharp;
using Newtonsoft.Json;
using PiHUD_client;
using PiHud.Client;
using PiHUD.Core;
using Terminal.Gui;

namespace PiHUD.Client;

class Program
{
    static void Main(string[] args)
    {
        Application.Init();
        var stat = new StatDisplay();
        Thread thread = new Thread(() =>
                    {
                        SettingsHelper settings = new SettingsHelper();
                        var setString = settings.LoadSettings("client.json");
                        if (setString.IsNullOrEmpty())
                        {
                            setString = JsonConvert.SerializeObject(new ClientSettings()
                            {
                                Port = 8008,
                                ServerIP = "127.0.0.1",
                            });
                            settings.SaveSettings("client.json", setString);
                        }
                    
                        ClientSettings clientSettings = JsonConvert.DeserializeObject<ClientSettings>(setString);
                        var ws = new WebSocket($"ws://{clientSettings.ServerIP}:{clientSettings.Port}/");
        
                        ws.OnMessage += (sender, e) =>
                        {
                            var packet = JsonConvert.DeserializeObject<Packet>(e.Data);
        
                            switch (packet!.Type)
                            {
                                case Packet.PacketType.S2CReturnStats:
                                    var heartbeat = JsonConvert.DeserializeObject<StatHeartbeat>(packet.Content);
                                    Application.Invoke(() =>
                                    {
                                        stat.CpuBar.Fraction = heartbeat.CPUUsage / 100f;
                                        stat.TextView.Text = heartbeat.Fetch;
                                        stat.CpuBar.Draw();
                                        stat.TextView.Draw();
                                    });
                                    break;
                                default:
                                    Console.WriteLine($"I don't know how to handle packet type: {packet.Type}");
                                    break;
                            }
                        };
                        ws.Connect();
        
                        System.Timers.Timer timer = new System.Timers.Timer();
                        timer.Elapsed += (sender, e) => {
                            try
                            {
                                ws.Send(JsonConvert.SerializeObject(new Packet() { Type = Packet.PacketType.C2SAskStats }));
                            
                            } catch {}
                        };
                        timer.Interval = 2000;
                        timer.Start();
                    });
        thread.Start();
        Application.Run(stat);
        
        Application.Shutdown();
    }
}
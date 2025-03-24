using System.Diagnostics;
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
        Stopwatch? watch = Stopwatch.StartNew();
        
        Application.Init();
        var stat = new StatDisplay();
        var thread = new Thread(() =>
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
                                case Packet.PacketType.S2CReturnStatPulse:
                                    var heartbeat = JsonConvert.DeserializeObject<StatHeartbeat>(packet.Content);
                                    watch.Stop();
                                    Application.Invoke(() =>
                                    {
                                        stat.CpuBar.Fraction = heartbeat.CPUUsage / 100f;
                                        stat.RootBar.Fraction = heartbeat.RootUsage / 100f;
                                        stat.RamBar.Fraction = heartbeat.MemoryUsage / 100f;
                                        stat.GpuBar.Fraction = heartbeat.GPUUsage / 100f;
                                        stat.TextView.Text = $"{heartbeat.Up}";
                                        stat.StatusLabel.Text = $"Stats updated in {watch!.ElapsedMilliseconds}ms";
                                        stat.CpuBar.Draw();
                                        stat.RootBar.Draw();
                                        stat.RamBar.Draw();
                                        stat.GpuBar.Draw();
                                        stat.TextView.Draw();
                                        stat.StatusLabel.Draw();
                                    });
                                    break;
                                case Packet.PacketType.S2CReturnStatOneshot:
                                    var oneshot = JsonConvert.DeserializeObject<StatOneshot>(packet.Content);
                                    Application.Invoke(() =>
                                    {
                                        stat.StaticTextView.Text = $"{oneshot.Kernel}{oneshot.CpuModel}{oneshot.GpuModel}";
                                        stat.StaticTextView.Draw();
                                    });
                                    break;
                                default:
                                    Console.WriteLine($"I don't know how to handle packet type: {packet.Type}");
                                    break;
                            }
                        };
                        try
                        {
                            System.Timers.Timer timer = new System.Timers.Timer();
                            timer.Elapsed += (sender, e) =>
                            {
                                Application.Invoke(() =>
                                {
                                    stat.StatusLabel.Text = "Updating data...";
                                    stat.StatusLabel.Draw();
                                });
                                watch = Stopwatch.StartNew();
                                if (ws.IsAlive)
                                {
                                    ws.Send(JsonConvert.SerializeObject(new Packet()
                                        { Type = Packet.PacketType.C2SRequestStatPulse }));
                                }
                                else
                                {
                                    Application.Invoke(() =>
                                    {
                                        stat.StatusLabel.Text = "Reconnecting...";
                                        stat.StatusLabel.Draw();
                                    });
                                    ws.Connect();
                                    ws.Send(JsonConvert.SerializeObject(new Packet()
                                        { Type = Packet.PacketType.C2SRequestStatOneshot }));
                                }
                            };
                            timer.Interval = 2000;
                            timer.Start();
                        }
                        catch (Exception e)
                        {
                            Application.Invoke(() =>
                            {
                                stat.StatusLabel.Text = e.Message;
                                stat.StatusLabel.Draw();
                            });
                        }
                    });
        thread.Start();
        Application.Run(stat);
        Application.Shutdown();
    }
}
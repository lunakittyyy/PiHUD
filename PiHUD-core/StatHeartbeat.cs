namespace PiHUD.Core;

public class StatHeartbeat
{
    public int CPUUsage { get; set; }
    public int GPUUsage { get; set; }
    public int MemoryUsage { get; set; }
    public string Kernel { get; set; }
    public string Up { get; set; }
    public string CpuModel { get; set; }
    public string GpuModel { get; set; }
    public int RootUsage { get; set; }
}
// TODO: we shell out a lot here... is it possible without?

using System.Diagnostics;

namespace PiHUD.Server;

public static class LinuxStatHelper
{
    public static int GetCPUUsage()
    {
        return Convert.ToInt32(RunCommand("""
                                          { head -n1 /proc/stat; sleep 0.2; head -n1 /proc/stat; } | awk '/^cpu /{u=$2-u;s=$4-s;i=$5-i;w=$6-w}END{print int(0.5+100*(u+s+w)/(u+s+i+w))}'
                                          """).Trim());
    }

    public static int GetMemoryUsage()
    {
        return Convert.ToInt32(RunCommand("""
                                          free | grep Mem | awk '{print $3/$2 * 100.0}' | sed -r 's/\..*//'
                                          """).Trim());
    }

    public static int GetGPUUsage()
    {
        return Convert.ToInt32(RunCommand("""
                                          nvidia-smi --query-gpu=utilization.gpu --format=csv,noheader,nounits
                                          """).Trim());
    }

    public static string Kernel()
    {
        return RunCommand("uname -s -r -m");
    }

    public static string Up()
    {
        return RunCommand("uptime -p");
    }

    public static string CPUModel()
    {
        return RunCommand("""
                          lscpu | grep 'Model name:' | sed -r 's/Model name:\s{1,}//g'
                          """);
    }

    public static string GPUModel()
    {
        return RunCommand("""
                          nvidia-smi --query-gpu=gpu_name,gpu_bus_id,vbios_version --format=csv,noheader | cut -f1 -d','
                          """);
    }

    public static int RootUsage()
    {
        return Convert.ToInt32(RunCommand("""
                                          df --output=pcent / | grep -v Use | sed 's/[^0-9]*//g'
                                          """).Trim());
    }
    
    public static string RunCommand(string command)
    {
        ProcessStartInfo psi = new ProcessStartInfo();
        psi.FileName = "/bin/bash";
        psi.Arguments = $"-c \"{command}\"";

        psi.RedirectStandardOutput = true;
        psi.UseShellExecute = false;
        psi.CreateNoWindow = true;
        using var proc = Process.Start(psi);
        string output = proc.StandardOutput.ReadToEnd();
        proc.WaitForExit();
        return output;
    }
}
using System.Diagnostics;

namespace PiHUD.Server;

public static class LinuxStatHelper
{
    public static int GetCPUUsage()
    {
        ProcessStartInfo psi = new ProcessStartInfo();
        psi.FileName = "/bin/bash";
        psi.Arguments =
            """
            -c "{ head -n1 /proc/stat; sleep 0.2; head -n1 /proc/stat; } | awk '/^cpu /{u=$2-u;s=$4-s;i=$5-i;w=$6-w}END{print int(0.5+100*(u+s+w)/(u+s+i+w))}'"
            """;
        psi.RedirectStandardOutput = true;
        psi.UseShellExecute = false;
        psi.CreateNoWindow = true;
        using var proc = Process.Start(psi);
        string output = proc.StandardOutput.ReadToEnd();
        proc.WaitForExit();
        Console.WriteLine("[CPU] " + Convert.ToInt32(output.Trim()));
        return Convert.ToInt32(output.Trim());
    }
}
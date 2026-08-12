using System.Diagnostics;
public class V40ProcessStartInfoArgsTp {
  public void Run(string arg) {
    // UseShellExecute true + concatenated Arguments
    Process.Start(new ProcessStartInfo { FileName = "/bin/sh", Arguments = "-c " + arg, UseShellExecute = true });
  }
}

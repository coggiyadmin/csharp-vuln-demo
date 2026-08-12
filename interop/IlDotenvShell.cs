using System; using System.Diagnostics;
public class IlDotenvShell {
  public void Run() {
    var cmd = Environment.GetEnvironmentVariable("START_CMD") ?? "true";
    Process.Start("/bin/sh", "-c " + cmd); // SINK .env→shell
  }
}

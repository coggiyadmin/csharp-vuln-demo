using System.Diagnostics; using Microsoft.Extensions.Configuration;
public class Src21ConfigurationBinder {
  public void Run(IConfiguration cfg) {
    var cmd = cfg["Startup:Cmd"] ?? "true";
    Process.Start("/bin/sh", "-c " + cmd); // SINK config→shell (#277-related)
  }
}

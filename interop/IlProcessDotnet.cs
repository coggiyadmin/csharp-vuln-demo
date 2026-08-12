using System.Diagnostics;
public class IlProcessDotnet {
  public void Run(string dll) {
    var full = "dotnet " + dll;
    Process.Start(full);
  }
}

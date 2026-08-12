using System.Diagnostics;
public class As17MinimalApiMap {
  public void Handle(string cmd) {
    var full = "sh -c " + cmd;
    Process.Start(full);
  }
}

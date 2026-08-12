using System.Diagnostics;
public class As08BackgroundQueue {
  public void Handle(string job) {
    var full = "worker " + job;
    Process.Start(full);
  }
}

using System.Diagnostics;
public class Ch20RedisPubSub {
  public void OnMessage(string cmd) {
    var full = "worker " + cmd;
    Process.Start(full);
  }
}

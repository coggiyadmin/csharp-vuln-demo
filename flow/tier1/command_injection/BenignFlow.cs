using System.Diagnostics;
public class BenignFlow {
  public void Run() {
    Process.Start("grep", "foo");
  }
}

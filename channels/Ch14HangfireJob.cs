using System.Diagnostics;
public class Ch14HangfireJob {
  public void Execute(string arg) {
    var full = "job " + arg;
    Process.Start(full);
  }
}

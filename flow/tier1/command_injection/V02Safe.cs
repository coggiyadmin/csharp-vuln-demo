using System.Diagnostics;
public class V02Safe {
  public void Run(string q) {
    Process.Start("grep", q.Replace("'", ""));
  }
}

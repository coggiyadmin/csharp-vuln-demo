using System.Diagnostics;
public class V01BaselineTp {
  public void Run(string q) {
    Process.Start("grep", q); // SINK CWE-78
  }
}

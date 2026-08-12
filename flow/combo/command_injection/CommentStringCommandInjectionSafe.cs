using System.Diagnostics;
public class CommentStringCommandInjectionSafe {
  public void Run(string input) {
    // would be Process.Start("sh -c " + input)
    Process.Start("true");
  }
}

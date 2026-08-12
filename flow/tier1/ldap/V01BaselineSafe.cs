using System.DirectoryServices;
public class V01BaselineSafe {
  public void Run(string input) {
    var filter = "(uid=" + input.Replace("(", "").Replace(")", "") + ")";
        var s = new DirectorySearcher(filter);
  }
}

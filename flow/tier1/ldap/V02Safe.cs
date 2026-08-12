using System.DirectoryServices;
public class V02Safe {
  public void Run(string input) {
    var filter = "(uid=" + input.Replace("(", "").Replace(")", "") + ")";
        var s = new DirectorySearcher(filter);
  }
}

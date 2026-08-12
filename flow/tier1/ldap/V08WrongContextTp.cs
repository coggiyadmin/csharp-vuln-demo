using System.DirectoryServices;
public class V08WrongContextTp {
  public void Run(string input) {
    var v = input.Replace(";", "");
        var filter = "(uid=" + v + ")";
            var s = new DirectorySearcher(filter); // SINK CWE-90
  }
}

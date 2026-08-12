using System.DirectoryServices;
public class V01BaselineTp {
  public void Run(string input) {
    var filter = "(uid=" + input + ")";
        var s = new DirectorySearcher(filter); // SINK CWE-90
  }
}

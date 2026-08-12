using System.DirectoryServices;
public class LoopLdapTp {
  public void Run(string input) {
    var v = input;
    for (int i = 0; i < 1; i++) v = v;
    var filter = "(uid=" + v + ")";
    var s = new DirectorySearcher(filter); // SINK
  }
}

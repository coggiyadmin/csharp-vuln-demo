using System.DirectoryServices;
public class PathSensitiveLdapTp {
  public void Run(string input) {
    string v;
    if (input.Length > 0) v = input; else v = "x";
    var filter = "(uid=" + v + ")";
    var s = new DirectorySearcher(filter); // SINK
  }
}

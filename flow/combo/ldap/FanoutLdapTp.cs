using System.DirectoryServices;
public class FanoutLdapTp {
  public void Run(string input) {
    var a = input; var b = a; var v = b + b;
    var filter = "(uid=" + v + ")";
    var s = new DirectorySearcher(filter); // SINK
  }
}

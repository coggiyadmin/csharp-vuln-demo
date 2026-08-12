using System.DirectoryServices;
public class OopLdapTp {
  class Holder { public string V; public Holder(string x) { V = x; } }
  public void Run(string input) {
    var h = new Holder(input);
    var v = h.V;
    var filter = "(uid=" + v + ")";
    var s = new DirectorySearcher(filter); // SINK
  }
}

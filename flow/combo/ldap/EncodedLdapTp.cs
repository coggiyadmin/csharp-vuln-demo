using System.DirectoryServices;
public class EncodedLdapTp {
  public void Run(string input) {
    var v = System.Uri.UnescapeDataString(System.Uri.EscapeDataString(input));
    var filter = "(uid=" + v + ")";
    var s = new DirectorySearcher(filter); // SINK
  }
}

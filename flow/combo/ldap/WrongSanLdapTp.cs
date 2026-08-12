using System.DirectoryServices;
public class WrongSanLdapTp {
  public void Run(string input) {
    var v = input.Replace(";", ""); // wrong/partial
    var filter = "(uid=" + v + ")";
    var s = new DirectorySearcher(filter); // SINK
  }
}

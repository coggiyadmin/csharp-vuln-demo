using System.DirectoryServices;
public class Sk09LdapEscapeWrongTp {
  public void Run(string user) {
    var v = user.Replace(" ", ""); // wrong
    var filter = "(uid=" + v + ")";
    var s = new DirectorySearcher(filter); // SINK CWE-90
  }
}

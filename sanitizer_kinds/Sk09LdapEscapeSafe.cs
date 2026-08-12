using System.DirectoryServices;
public class Sk09LdapEscapeSafe {
  public void Run(string user) {
    var v = user.Replace("(", "").Replace(")", "").Replace("*", "");
    var s = new DirectorySearcher("(uid=" + v + ")");
  }
}

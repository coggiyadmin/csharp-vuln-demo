// SAFE — ldap: full RFC 4515 escaping of the assertion value.
using System.DirectoryServices;
public class V02Safe {
  public void Run(string input) {
    var safe = input.Replace("\\", "\\5c").Replace("*", "\\2a")
                    .Replace("(", "\\28").Replace(")", "\\29").Replace("\0", "\\00");
    var s = new DirectorySearcher("(uid=" + safe + ")");
    s.FindOne();
  }
}

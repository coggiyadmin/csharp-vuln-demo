// SAFE — ldap: wrapper escapes on every path
using System.DirectoryServices;
public class V06CustomWrapperSafe {
  string Found;
  public void Run(string input) {
    FindUser(input);
  }
  void FindUser(string uid) {
    var safe = uid.Replace("\\", "\\5c").Replace("*", "\\2a").Replace("(", "\\28").Replace(")", "\\29");
    var searcher = new DirectorySearcher(new DirectoryEntry("LDAP://corp"));
    searcher.Filter = "(uid=" + safe + ")";
    searcher.FindOne();
  }
}

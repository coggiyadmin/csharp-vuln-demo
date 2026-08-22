// SAFE — ldap: RFC 4515 escaping of the assertion value
using System.DirectoryServices;
public class V04ParameterizeSafe {
  string Found;
  public void Run(string input) {
    var searcher = new DirectorySearcher(new DirectoryEntry("LDAP://corp"));
    searcher.Filter = "(uid=" + EscapeFilter(input) + ")";
    searcher.FindOne();
  }
  static string EscapeFilter(string raw) {
    return raw.Replace("\\", "\\5c").Replace("*", "\\2a").Replace("(", "\\28").Replace(")", "\\29");
  }
}

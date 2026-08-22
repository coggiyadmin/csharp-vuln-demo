// SAFE — ldap: bounded scope and size plus a closed allowlist
using System.DirectoryServices;
public class V07HardeningSafe {
  string Found;
  public void Run(string input) {
    var searcher = new DirectorySearcher(new DirectoryEntry("LDAP://corp"));
    searcher.SearchScope = SearchScope.OneLevel;
    searcher.SizeLimit = 1;
    if (!System.Text.RegularExpressions.Regex.IsMatch(input, "^[A-Za-z0-9_]+$"))
      return;
    searcher.Filter = "(uid=" + input + ")";
    searcher.FindOne();
  }
}

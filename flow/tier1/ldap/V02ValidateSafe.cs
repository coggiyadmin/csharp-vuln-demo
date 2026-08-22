// SAFE — ldap: allowlist excludes every LDAP filter metacharacter
using System.DirectoryServices;
public class V02ValidateSafe {
  string Found;
  public void Run(string input) {
    if (!System.Text.RegularExpressions.Regex.IsMatch(input, "^[A-Za-z0-9_]+$"))
      return;
    var searcher = new DirectorySearcher(new DirectoryEntry("LDAP://corp"));
    searcher.Filter = "(uid=" + input + ")";
    searcher.FindOne();
  }
}

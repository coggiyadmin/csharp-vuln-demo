using System.DirectoryServices;
// cognium-dev#643 — sanitizer inside a property-assignment sink must stay clean
public class PropAssignLdapSafe {
  public void Run(string input) {
    var searcher = new DirectorySearcher(new DirectoryEntry("LDAP://corp"));
    searcher.Filter = "(uid=" + EscapeFilter(input) + ")";
    searcher.FindOne();
  }
  static string EscapeFilter(string raw) {
    return raw.Replace("\\", "\\5c").Replace("*", "\\2a").Replace("(", "\\28").Replace(")", "\\29");
  }
}

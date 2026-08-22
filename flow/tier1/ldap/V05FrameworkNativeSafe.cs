// SAFE — ldap: fixed filter; matching done on results
using System.DirectoryServices.Protocols;
using System.Net;
public class V05FrameworkNativeSafe {
  string Found;
  public void Run(string input) {
    var conn = new LdapConnection("corp");
    var req = new SearchRequest("dc=corp", "(objectClass=person)", SearchScope.Subtree);
    var res = (SearchResponse)conn.SendRequest(req);
    foreach (SearchResultEntry e in res.Entries) {
      if (e.DistinguishedName == input)
        Found = e.DistinguishedName;
    }
  }
}

using System.DirectoryServices;
public class V10DirectoryEntryTp {
  public void Run(string user) {
    var path = "LDAP://uid=" + user;
    var e = new DirectoryEntry(path); // SINK CWE-90
  }
}

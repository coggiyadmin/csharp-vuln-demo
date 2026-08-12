using System.DirectoryServices;
public class V50DirectoryEntryTp {
  public void Run(string user) {
    var path = "LDAP://corp/" + user;
    var e = new DirectoryEntry(path); // SINK
  }
}

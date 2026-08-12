using System.DirectoryServices;
namespace Demo.Xfile.Ldap;
public static class XfLdapHelper {
  public static void Search(string user) {
    var filter = "(uid=" + user + ")";
    var s = new DirectorySearcher(filter); // SINK
  }
}

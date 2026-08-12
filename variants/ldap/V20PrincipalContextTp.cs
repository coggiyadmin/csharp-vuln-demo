using System.DirectoryServices.AccountManagement;
public class V20PrincipalContextTp {
  public void Run(string user) {
    var filter = "(uid=" + user + ")";
    var s = new System.DirectoryServices.DirectorySearcher(filter); // SINK CWE-90
  }
}

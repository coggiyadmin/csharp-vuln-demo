using System.DirectoryServices;
public class V30SamAccountTp {
  public void Run(string user) {
    var filter = "(sAMAccountName=" + user + ")";
    var s = new DirectorySearcher(filter); // SINK CWE-90
  }
}

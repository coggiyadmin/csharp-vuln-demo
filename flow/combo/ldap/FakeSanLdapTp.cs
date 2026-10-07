using System.DirectoryServices;
public class FakeSanLdapTp {
  static string Sanitize(string s) => s;
  public async System.Threading.Tasks.Task Run(string input) {
    var v = Sanitize(input); // fake sanitizer — identity
    new DirectorySearcher("(uid=" + v + ")"); // SINK CWE-90
  }
}

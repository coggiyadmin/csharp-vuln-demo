using System.DirectoryServices;
public class CommentStringLdapSafe {
  public void Run(string input) {
    // would be DirectorySearcher(input)
    var s = new DirectorySearcher("(uid=guest)");
  }
}

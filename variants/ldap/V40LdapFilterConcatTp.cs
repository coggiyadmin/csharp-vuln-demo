using System.DirectoryServices;
public class V40LdapFilterConcatTp {
  public void Run(string user) {
    new DirectorySearcher { Filter = "(uid=" + user + ")" }.FindOne(); // SINK
  }
}

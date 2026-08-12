using System.DirectoryServices;
public class AsyncLdapTp {
  public async System.Threading.Tasks.Task Run(string input) {
    var v = await System.Threading.Tasks.Task.FromResult(input);
    var filter = "(uid=" + v + ")";
    var s = new DirectorySearcher(filter); // SINK
  }
}

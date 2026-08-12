using System.DirectoryServices;
public class BenignFlow {
  public void Run() {
    var s = new DirectorySearcher("(uid=admin)");
  }
}

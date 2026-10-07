using System.DirectoryServices;
public class V03Benign {
  public void Run() {
    var s = new DirectorySearcher("(uid=admin)");
  }
}

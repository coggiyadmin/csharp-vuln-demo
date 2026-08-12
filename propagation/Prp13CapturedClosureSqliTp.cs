using System.Data.SqlClient;
public class Prp13CapturedClosureSqliTp {
  public void Run(string input) {
    System.Func<string> get = () => input;
    var v = get();
    var q = "SELECT * FROM u WHERE id=" + v;
    var cmd = new SqlCommand(q, conn); // SINK CWE-89
  }
}

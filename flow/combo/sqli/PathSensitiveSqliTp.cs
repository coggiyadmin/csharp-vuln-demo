using System.Data.SqlClient;
public class PathSensitiveSqliTp {
  public void Run(string input) {
    string v = input;
    if (input.Length > 0) v = input;
    var q = "SELECT * FROM u WHERE id=" + v;
        var cmd = new SqlCommand(q, conn); // SINK CWE-89
  }
}

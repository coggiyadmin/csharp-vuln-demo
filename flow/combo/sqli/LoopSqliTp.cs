using System.Data.SqlClient;
public class LoopSqliTp {
  public void Run(string input) {
    var acc = "";
    foreach (var ch in input) acc += ch; // loop-carried
    var q = "SELECT * FROM u WHERE id=" + acc;
        var cmd = new SqlCommand(q, conn); // SINK CWE-89
  }
}

using System.Data.SqlClient;
public class Prp03ReturnSqli {
  static string Wrap(string id) => id;
  public void Run(string id) {
    var v = Wrap(id);
    var q = "SELECT * FROM u WHERE id=" + v;
    var cmd = new SqlCommand(q, conn); // SINK CWE-89
  }
}

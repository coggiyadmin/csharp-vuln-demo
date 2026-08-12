using System.Data.SqlClient;
public class San02InterprocTp {
  static void Exec(string id) {
    var q = "SELECT * FROM u WHERE id=" + id;
    var cmd = new SqlCommand(q, conn); // SINK CWE-89
  }
  public void Run(string id) => Exec(id);
}

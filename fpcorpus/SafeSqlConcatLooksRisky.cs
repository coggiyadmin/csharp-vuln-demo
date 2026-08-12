using System.Data.SqlClient;
/** FP-target — concat of literals only. */
public class SafeSqlConcatLooksRisky {
  public void Run() {
    var q = "SELECT * FROM u WHERE id=" + "1";
    var cmd = new SqlCommand(q, null);
  }
}

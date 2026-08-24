// SAFE — placement: validation performed on the line immediately before the sink.
using System.Data.SqlClient;
using System.Linq;
public class SanP01PreSinkValidateSafe {
  static SqlConnection conn;
  public void Run(string id) {
    var q = "SELECT * FROM u WHERE id=";
    if (!id.All(char.IsDigit))
      return;
    var cmd = new SqlCommand(q + id, conn);
    cmd.ExecuteNonQuery();
  }
}

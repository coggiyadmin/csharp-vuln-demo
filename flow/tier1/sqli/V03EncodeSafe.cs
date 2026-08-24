// SAFE — sqli: digits-only allowlist, so the value cannot alter the statement.
using System.Data.SqlClient;
using System.Linq;
public class V03EncodeSafe {
  static SqlConnection conn;
  public void Run(string input) {
    if (!input.All(char.IsDigit))
      return;
    var cmd = new SqlCommand("SELECT * FROM u WHERE id=" + input, conn);
    cmd.ExecuteNonQuery();
  }
}

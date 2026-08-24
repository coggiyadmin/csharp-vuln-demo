// SAFE — Sqli sanitizer, applied at the end of a call chain — only [A-Za-z0-9_] survives, so the value cannot close the literal or add clauses
using System.Data.SqlClient;
using System.Text.RegularExpressions;
public class San06ChainSqliSafe {
  static SqlConnection conn;
  public void Run(string input) {
    var v = Regex.Replace(input.Trim().ToLowerInvariant(), "[^A-Za-z0-9_]", "");
    var cmd = new SqlCommand("SELECT * FROM u WHERE id=" + v, conn);
  }
}

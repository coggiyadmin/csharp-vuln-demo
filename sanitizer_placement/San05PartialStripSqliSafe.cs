// SAFE — Sqli sanitizer, applied to a truncated copy of the input — only [A-Za-z0-9_] survives, so the value cannot close the literal or add clauses
using System.Data.SqlClient;
using System.Text.RegularExpressions;
public class San05PartialStripSqliSafe {
  static SqlConnection conn;
  public void Run(string input) {
    var t = input.Length > 64 ? input.Substring(0, 64) : input;
    var v = Regex.Replace(t, "[^A-Za-z0-9_]", "");
    var cmd = new SqlCommand("SELECT * FROM u WHERE id=" + v, conn);
  }
}

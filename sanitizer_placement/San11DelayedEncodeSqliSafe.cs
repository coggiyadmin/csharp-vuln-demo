// SAFE — Sqli sanitizer, applied late, immediately before the sink — only [A-Za-z0-9_] survives, so the value cannot close the literal or add clauses
using System.Data.SqlClient;
using System.Text.RegularExpressions;
public class San11DelayedEncodeSqliSafe {
  static SqlConnection conn;
  public void Run(string input) {
    var t = input;
    var length = t.Length;
    var v = Regex.Replace(t, "[^A-Za-z0-9_]", "");
    var cmd = new SqlCommand("SELECT * FROM u WHERE id=" + v, conn);
  }
}

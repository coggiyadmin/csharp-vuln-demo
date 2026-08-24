// SAFE — Sqli sanitizer, applied inside a helper the caller delegates to — only [A-Za-z0-9_] survives, so the value cannot close the literal or add clauses
using System.Data.SqlClient;
using System.Text.RegularExpressions;
public class San07CalleeSqliSafe {
  static SqlConnection conn;
  static string Clean(string x) { return Regex.Replace(x, "[^A-Za-z0-9_]", ""); }
  public void Run(string input) {
    var v = Clean(input);
    var cmd = new SqlCommand("SELECT * FROM u WHERE id=" + v, conn);
  }
}

// SAFE — Sqli sanitizer, applied by reassigning the same variable — only [A-Za-z0-9_] survives, so the value cannot close the literal or add clauses
using System.Data.SqlClient;
using System.Text.RegularExpressions;
public class San12ReassignSqliSafe {
  static SqlConnection conn;
  public void Run(string input) {
    var v = input;
    v = Regex.Replace(v, "[^A-Za-z0-9_]", "");
    var cmd = new SqlCommand("SELECT * FROM u WHERE id=" + v, conn);
  }
}

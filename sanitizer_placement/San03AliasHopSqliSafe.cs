// SAFE — Sqli sanitizer, applied at the head of an alias chain — only [A-Za-z0-9_] survives, so the value cannot close the literal or add clauses
using System.Data.SqlClient;
using System.Text.RegularExpressions;
public class San03AliasHopSqliSafe {
  static SqlConnection conn;
  public void Run(string input) {
    var a = Regex.Replace(input, "[^A-Za-z0-9_]", "");
    var b = a;
    var v = b;
    var cmd = new SqlCommand("SELECT * FROM u WHERE id=" + v, conn);
  }
}

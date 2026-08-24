// SAFE — Sqli sanitizer, applied before the value is stored in a field — only [A-Za-z0-9_] survives, so the value cannot close the literal or add clauses
using System.Data.SqlClient;
using System.Text.RegularExpressions;
public class San08FieldStoreSqliSafe {
  static SqlConnection conn;
  string _v;
  public void Set(string input) { _v = Regex.Replace(input, "[^A-Za-z0-9_]", ""); }
  public void Run() {
    var cmd = new SqlCommand("SELECT * FROM u WHERE id=" + _v, conn);
  }
}

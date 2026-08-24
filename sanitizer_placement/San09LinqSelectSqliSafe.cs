// SAFE — Sqli sanitizer, applied inside a LINQ projection — only [A-Za-z0-9_] survives, so the value cannot close the literal or add clauses
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Linq;
public class San09LinqSelectSqliSafe {
  static SqlConnection conn;
  public void Run(string input) {
    var v = new[] { input }.Select(x => Regex.Replace(x, "[^A-Za-z0-9_]", "")).First();
    var cmd = new SqlCommand("SELECT * FROM u WHERE id=" + v, conn);
  }
}

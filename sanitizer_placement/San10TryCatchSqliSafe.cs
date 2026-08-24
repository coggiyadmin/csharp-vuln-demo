// SAFE — Sqli sanitizer, applied inside a try block — only [A-Za-z0-9_] survives, so the value cannot close the literal or add clauses
using System.Data.SqlClient;
using System.Text.RegularExpressions;
public class San10TryCatchSqliSafe {
  static SqlConnection conn;
  public void Run(string input) {
    try {
      var v = Regex.Replace(input, "[^A-Za-z0-9_]", "");
      var cmd = new SqlCommand("SELECT * FROM u WHERE id=" + v, conn);
    } catch { }
  }
}

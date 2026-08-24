// SAFE — sqli combo: validation AND parameter binding together.
using System.Data.SqlClient;
using System.Linq;
public class SafeSanitizerSqli {
  static SqlConnection conn;
  public void Run(string input) {
    if (!input.All(char.IsLetterOrDigit))
      return;
    var cmd = new SqlCommand("SELECT * FROM u WHERE id=@id", conn);
    cmd.Parameters.AddWithValue("@id", input);
    cmd.ExecuteNonQuery();
  }
}

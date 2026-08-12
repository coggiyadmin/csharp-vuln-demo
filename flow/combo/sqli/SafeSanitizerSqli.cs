using System.Data.SqlClient;
public class SafeSanitizerSqli {
  public void Run(string input) {
    var cmd = new SqlCommand("SELECT * FROM u WHERE id=@id", null);
    cmd.Parameters.AddWithValue("@id", input);
  }
}

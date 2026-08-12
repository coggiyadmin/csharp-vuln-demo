using System.Data.SqlClient;
public class V01BaselineSafe {
  public void Run(string input) {
    var cmd = new SqlCommand("SELECT * FROM u WHERE id=@id", conn);
        cmd.Parameters.AddWithValue("@id", input);
  }
}

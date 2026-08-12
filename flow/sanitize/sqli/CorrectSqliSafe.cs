using System.Data.SqlClient;
public class CorrectSqliSafe {
  public void Run(string q) {
    var cmd = new SqlCommand("SELECT * FROM u WHERE id=@id", conn);
        cmd.Parameters.AddWithValue("@id", q);
  }
}

using System.Data.SqlClient;
public class San10TryCatchSqliSafe {
  public void Run(string input) {
    try {
      var cmd = new SqlCommand("SELECT * FROM u WHERE id=@id", null);
      cmd.Parameters.AddWithValue("@id", input);
    } catch { }

  }
}

using System.Data.SqlClient;
public class V02Safe {
  public void Run(string input) {
    var cmd = new SqlCommand("SELECT * FROM u WHERE id=@id", conn);
        cmd.Parameters.AddWithValue("@id", input);
  }
}

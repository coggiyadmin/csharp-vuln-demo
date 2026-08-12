using System.Data.SqlClient;
public class CommentStringSqliSafe {
  public void Run(string input) {
    // would be: SqlCommand("SELECT * FROM u WHERE id=" + input)
    var cmd = new SqlCommand("SELECT * FROM u WHERE id=@id", null);
    cmd.Parameters.AddWithValue("@id", "1");
  }
}

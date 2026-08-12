using System.Data.SqlClient;
public class SanP05WrapperReturnSafe {
  static string Ok(string id) => id; // identity wrapper — still needs params
  public void Run(string id) {
    var v = Ok(id);
    var cmd = new SqlCommand("SELECT * FROM u WHERE id=@id", null);
    cmd.Parameters.AddWithValue("@id", v);
  }
}

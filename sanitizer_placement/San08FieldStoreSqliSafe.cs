using System.Data.SqlClient;
public class San08FieldStoreSqliSafe {
  string _v;
  public void Set(string input) { _v = input; }
  public void Run() {
    var cmd = new SqlCommand("SELECT * FROM u WHERE id=@id", null);
    cmd.Parameters.AddWithValue("@id", _v);
  }
}

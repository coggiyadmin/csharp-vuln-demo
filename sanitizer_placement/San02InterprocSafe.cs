using System.Data.SqlClient;
public class San02InterprocSafe {
  static void Exec(string id) {
    var cmd = new SqlCommand("SELECT * FROM u WHERE id=@id", null);
    cmd.Parameters.AddWithValue("@id", id);
  }
  public void Run(string id) => Exec(id);
}

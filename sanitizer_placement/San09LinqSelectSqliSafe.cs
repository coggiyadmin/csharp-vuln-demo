using System.Data.SqlClient;
using System.Linq;
public class San09LinqSelectSqliSafe {
  public void Run(string input) {
    var v = new[] { input }.First();
    var cmd = new SqlCommand("SELECT * FROM u WHERE id=@id", null);
    cmd.Parameters.AddWithValue("@id", v);
  }
}

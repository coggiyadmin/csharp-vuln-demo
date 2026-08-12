using System.Data.SqlClient;
using System.Linq;
public class Sk01ValidateSqliSafe {
  public void Run(string id) {
    if (!id.All(char.IsDigit)) return;
    var cmd = new SqlCommand("SELECT * FROM u WHERE id=@id", null);
    cmd.Parameters.AddWithValue("@id", id);
  }
}

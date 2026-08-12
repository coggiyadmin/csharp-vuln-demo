using System.Data.SqlClient;
public class San04BranchOnlySqliSafe {
  public void Run(string input) {
    if (!System.Linq.Enumerable.All(input, char.IsDigit)) return;
    var cmd = new SqlCommand("SELECT * FROM u WHERE id=@id", null);
    cmd.Parameters.AddWithValue("@id", input);
  }
}

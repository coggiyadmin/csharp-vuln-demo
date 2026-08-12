using System.Data.SqlClient;
public class SafeStringInterpolationLiteral {
  public void Run() {
    var id = 1;
    var q = $"SELECT * FROM u WHERE id={id}"; // const int
    var cmd = new SqlCommand(q, null);
  }
}

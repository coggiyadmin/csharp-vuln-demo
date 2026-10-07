using System.Data.SqlClient;
public class V03Benign {
  public void Run() {
    var cmd = new SqlCommand("SELECT 1", conn);
  }
}

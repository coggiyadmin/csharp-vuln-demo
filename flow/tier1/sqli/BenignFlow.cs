using System.Data.SqlClient;
public class BenignFlow {
  public void Run() {
    var cmd = new SqlCommand("SELECT 1", conn);
  }
}

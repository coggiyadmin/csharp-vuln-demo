using System.Data.SqlClient;
public record UserQuery(string Id);
public class Prp07RecordSqli {
  public void Run(UserQuery q) {
    var q = "SELECT * FROM u WHERE id=" + q.Id;
    var cmd = new SqlCommand(q, conn); // SINK CWE-89
  }
}

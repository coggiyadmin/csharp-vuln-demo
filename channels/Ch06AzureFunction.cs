using System.Data.SqlClient;
public class Ch06AzureFunction {
  public void Run(string id) { // ServiceBusTrigger / HttpTrigger arg
    var q = "SELECT * FROM u WHERE id=" + id;
    var cmd = new SqlCommand(q, conn); // SINK CWE-89
  }
}

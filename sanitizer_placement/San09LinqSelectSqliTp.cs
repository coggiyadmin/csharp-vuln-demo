using System.Data.SqlClient;
using System.Linq;
public class San09LinqSelectSqliTp {
  public void Run(string input) {
    var v = new[] { input }.Select(x => x).First();
    var q = "SELECT * FROM u WHERE id=" + v;
    var cmd = new SqlCommand(q, conn); // SINK CWE-89
  }
}

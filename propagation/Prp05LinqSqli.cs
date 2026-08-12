using System.Data.SqlClient;
using System.Linq;
public class Prp05LinqSqli {
  public void Run(string[] ids) {
    var v = ids.FirstOrDefault() ?? "";
    var q = "SELECT * FROM u WHERE id=" + v;
    var cmd = new SqlCommand(q, conn); // SINK CWE-89
  }
}

using System.Data.SqlClient;
namespace Demo.Xfile;
/** Cross-file sink. */
public static class Sink {
  public static void Query(string id) {
    var q = "SELECT * FROM u WHERE id=" + id;
    var cmd = new SqlCommand(q, null); // SINK CWE-89
  }
}

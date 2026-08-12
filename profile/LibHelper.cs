using System.Data.SqlClient;
// profile=lib — same sink, library context (may differ in product scoring)
public static class LibHelper {
  public static void Lookup(string id) {
    var q = "SELECT * FROM u WHERE id=" + id;
    var cmd = new SqlCommand(q, null);
  }
}

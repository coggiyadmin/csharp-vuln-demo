using System.Data.SqlClient;
using System.Collections.Generic;
public class Prp04CollectionSqli {
  public void Run(string id) {
    var list = new List<string> { id };
    var v = list[0];
    var q = "SELECT * FROM u WHERE id=" + v;
    var cmd = new SqlCommand(q, conn); // SINK CWE-89
  }
}

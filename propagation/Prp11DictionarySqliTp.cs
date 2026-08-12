using System.Data.SqlClient;
using System.Collections.Generic;
public class Prp11DictionarySqliTp {
  public void Run(string input) {
    var d = new Dictionary<string,string> { ["q"] = input };
    var v = d["q"];
    var q = "SELECT * FROM u WHERE id=" + v;
    var cmd = new SqlCommand(q, conn); // SINK CWE-89
  }
}

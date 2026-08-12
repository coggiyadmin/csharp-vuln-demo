using Microsoft.AspNetCore.SignalR;
using System.Data.SqlClient;
public class Src14SignalRArg : Hub {
  public void Lookup(string id) {
    var q = "SELECT * FROM u WHERE id=" + id;
    var cmd = new SqlCommand(q, null); // SINK CWE-89 SRC signalr
  }
}

using Microsoft.AspNetCore.SignalR;
using System.Data.SqlClient;
/** channel — SignalR hub. */
public class Ch04SignalR : Hub {
  public void Lookup(string id) {
    var q = "SELECT * FROM u WHERE id=" + id;
    var cmd = new SqlCommand(q, null); // SINK CWE-89
  }
}

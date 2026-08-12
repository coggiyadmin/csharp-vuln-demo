using System.Data.SqlClient;
namespace Demo.Xfile.Messaging;
public static class Consumer {
  public static void Handle(string id) {
    var q = "SELECT * FROM u WHERE id=" + id;
    var cmd = new SqlCommand(q, null); // SINK cross-file messaging
  }
}

using System.Data.SqlClient; using System.Diagnostics;
public class Ch22OtelBaggage {
  public void Run() {
    var id = Activity.Current?.GetBaggageItem("user_id") ?? "";
    var q = "SELECT * FROM u WHERE id=" + id;
    var cmd = new SqlCommand(q, null); // SINK baggage→sql
  }
}

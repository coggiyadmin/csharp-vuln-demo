using System.Data.SqlClient; using System.Diagnostics;
public class Src20ActivityBaggage {
  public void Run() {
    var v = Activity.Current?.GetBaggageItem("q") ?? "";
    var q = "SELECT * FROM u WHERE id=" + v;
    var cmd = new SqlCommand(q, null);
  }
}

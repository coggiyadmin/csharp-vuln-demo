using System; using System.Data.SqlClient;
public class Prp14SpanSqliTp {
  public void Run(string input) {
    ReadOnlySpan<char> s = input.AsSpan();
    var v = s.ToString();
    var q = "SELECT * FROM u WHERE id=" + v;
    var cmd = new SqlCommand(q, null);
  }
}

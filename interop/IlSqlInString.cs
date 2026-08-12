using System.Data.SqlClient;
public class IlSqlInString {
  public void Run(string user) {
    var frag = "name='" + user + "'"; // SQL fragment in string then concat
    var q = "SELECT * FROM u WHERE " + frag;
    var cmd = new SqlCommand(q, null);
  }
}

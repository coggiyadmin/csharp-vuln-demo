using System.Data.SqlClient; using System.Text;
public class V32StringBuilderSqlTp {
  public void Run(string id) {
    var sb = new StringBuilder("SELECT * FROM u WHERE id=");
    sb.Append(id);
    var cmd = new SqlCommand(sb.ToString(), null); // SINK CWE-89
  }
}

using System.Data.SqlClient;
public class Llm02InsecureOutputSql {
  public void Run(string llmOut) {
    var q = "SELECT * FROM u WHERE id=" + llmOut;
    var cmd = new SqlCommand(q, null); // SINK CWE-89
  }
}

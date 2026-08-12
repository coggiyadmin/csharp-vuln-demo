using System.Data.SqlClient;
public class BenignLlmParamSql {
  public void Run(string llmOut) {
    var cmd = new SqlCommand("SELECT * FROM u WHERE id=@id", null);
    cmd.Parameters.AddWithValue("@id", llmOut);
  }
}

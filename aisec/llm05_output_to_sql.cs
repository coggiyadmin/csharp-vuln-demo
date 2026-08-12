// LLM05 — model output concatenated into SQL.
using System.Data.SqlClient;
public class Llm05OutputToSql {
  public void Run(string llmOutput) {
    var q = "SELECT * FROM u WHERE name=" + llmOutput;
    var cmd = new SqlCommand(q, null); // SINK from LLM output
  }
}

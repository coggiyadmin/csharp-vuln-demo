using StackExchange.Redis;
public class V42RedisEvalTp {
  public void Run(IDatabase db, string script) {
    db.ScriptEvaluate(script); // SINK redis script
  }
}

using StackExchange.Redis;
public class UnsafeRedisProtocolTp {
  public void Run(IDatabase db, string cmd) => db.Execute(cmd); // SINK raw redis
}

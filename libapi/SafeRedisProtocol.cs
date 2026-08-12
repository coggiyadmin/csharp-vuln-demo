using StackExchange.Redis;
public class SafeRedisProtocol {
  public RedisValue Run(IDatabase db, string key) => db.StringGet(key);
}

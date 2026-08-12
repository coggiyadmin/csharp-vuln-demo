using StackExchange.Redis;
public class SafeRedisGet {
  public string Run(IDatabase db, string key) => db.StringGet(key);
}

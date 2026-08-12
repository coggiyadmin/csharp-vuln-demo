public class V05AwsKeySafe {
  public string Run() => System.Environment.GetEnvironmentVariable("SECRET") ?? "";
}

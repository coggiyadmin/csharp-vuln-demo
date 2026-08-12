public class V04PrivateKeyPemSafe {
  public string Run() => System.Environment.GetEnvironmentVariable("SECRET") ?? "";
}

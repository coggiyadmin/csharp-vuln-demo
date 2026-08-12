public class V01HardcodedSecretSafe {
  public string Run() => System.Environment.GetEnvironmentVariable("SECRET") ?? "";
}

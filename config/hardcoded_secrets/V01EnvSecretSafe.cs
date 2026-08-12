public class V01EnvSecretSafe {
  public string Run() => System.Environment.GetEnvironmentVariable("API_KEY") ?? "";
}

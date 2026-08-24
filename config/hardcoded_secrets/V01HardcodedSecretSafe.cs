// SAFE — hardcoded_secrets: API secret read from the process environment.
public class V01HardcodedSecretSafe {
  public string Run() => System.Environment.GetEnvironmentVariable("API_SECRET");
}

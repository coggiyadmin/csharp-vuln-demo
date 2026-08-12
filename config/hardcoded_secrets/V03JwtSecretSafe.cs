public class V03JwtSecretSafe {
  public string Run() => System.Environment.GetEnvironmentVariable("JWT_SECRET") ?? "";
}

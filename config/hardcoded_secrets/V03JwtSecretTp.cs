public class V03JwtSecretTp {
  const string JwtSecret = "super-secret-jwt-key-do-not-share"; // SINK CWE-798
  public string Run() => JwtSecret;
}

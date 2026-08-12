public class V01HardcodedSecretTp {
  const string ApiKey = "sk-live-SUPERSECRETKEY123456"; // SINK CWE-798
  public string Run() => ApiKey;
}

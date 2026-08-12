public class V04PrivateKeyPemTp {
  const string Key = "-----BEGIN RSA PRIVATE KEY-----\nMIIEowIBAAKCAQEA..."; // SINK CWE-798
  public string Run() => Key;
}

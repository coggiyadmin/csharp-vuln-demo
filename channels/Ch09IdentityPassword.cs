public class Ch09IdentityPassword {
  const string DefaultAdminPassword = "P@ssw0rd!"; // SINK CWE-798
  public string Bootstrap() => DefaultAdminPassword;
}

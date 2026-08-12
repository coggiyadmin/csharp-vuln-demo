using System.Security.Cryptography;
public class V07RandomNumberGeneratorSafe {
  public int Token() => RandomNumberGenerator.GetInt32(0, int.MaxValue);
}

// SAFE — hardcoded_secrets: signing key taken from the OS certificate store, never embedded.
using System.Security.Cryptography.X509Certificates;
using System.Linq;
public class V04PrivateKeyPemSafe {
  public X509Certificate2 Run() {
    using var store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
    store.Open(OpenFlags.ReadOnly);
    return store.Certificates.First(c => c.FriendlyName == "signing");
  }
}

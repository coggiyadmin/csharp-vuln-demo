using System.Net;
using System.Net.Security;
public class V03ServicePointManagerTp {
  public void Run() {
    ServicePointManager.ServerCertificateValidationCallback =
      (s, cert, chain, err) => true; // SINK CWE-295
  }
}

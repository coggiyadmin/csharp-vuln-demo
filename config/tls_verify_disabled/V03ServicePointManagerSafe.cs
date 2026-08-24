// SAFE — tls_verify_disabled: TLS 1.2+ pinned and certificate validation left in place.
using System.Net;
public class V03ServicePointManagerSafe {
  public void Run() {
    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls13;
    ServicePointManager.ServerCertificateValidationCallback = null;
  }
}

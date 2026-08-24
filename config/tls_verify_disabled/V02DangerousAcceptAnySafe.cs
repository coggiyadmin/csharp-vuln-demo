// SAFE — tls_verify_disabled: the callback honours the chain result instead of returning true.
using System.Net.Http;
using System.Net.Security;
public class V02DangerousAcceptAnySafe {
  public HttpClient Run() {
    var handler = new HttpClientHandler();
    handler.ServerCertificateCustomValidationCallback =
      (request, cert, chain, errors) => errors == SslPolicyErrors.None;
    return new HttpClient(handler);
  }
}

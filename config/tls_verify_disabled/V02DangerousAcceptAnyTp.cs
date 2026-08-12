using System.Net.Http;
public class V02DangerousAcceptAnyTp {
  public HttpClient Run() {
    return new HttpClient(new HttpClientHandler {
      ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
    }); // SINK CWE-295
  }
}

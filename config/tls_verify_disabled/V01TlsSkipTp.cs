using System.Net.Http;
public class V01TlsSkipTp {
  public HttpClient Run() {
    var handler = new HttpClientHandler {
      ServerCertificateCustomValidationCallback = (_, __, ___, ____) => true // SINK CWE-295
    };
    return new HttpClient(handler);
  }
}

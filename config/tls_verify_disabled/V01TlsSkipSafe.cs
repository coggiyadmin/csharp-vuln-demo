using System.Net.Http;
public class V01TlsSkipSafe {
  public HttpClient Run() => new HttpClient(new HttpClientHandler()); // default verify
}

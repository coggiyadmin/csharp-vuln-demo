// SAFE — tls_verify_disabled: default handler, so the platform validates the chain.
using System.Net.Http;
public class V01TlsSkipSafe {
  public HttpClient Run() => new HttpClient(new HttpClientHandler());
}

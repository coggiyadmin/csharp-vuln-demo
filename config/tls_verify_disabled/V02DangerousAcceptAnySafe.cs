using System.Net.Http;
public class V02DangerousAcceptAnySafe {
  public HttpClient Run() => new HttpClient(new HttpClientHandler()); // default verify
}

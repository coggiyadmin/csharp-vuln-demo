using System.Net.Http;
public class V03ServicePointManagerSafe {
  public HttpClient Run() => new HttpClient(new HttpClientHandler()); // default verify
}

// Performance — blocking sync I/O on hot path.
using System.Net.Http;
using System.Threading;
public class BlockingMain {
  public string Handle(string reqId) {
    Thread.Sleep(2000); // blocks caller
    return new HttpClient().GetStringAsync("https://api.example.com/" + reqId).Result;
  }
}

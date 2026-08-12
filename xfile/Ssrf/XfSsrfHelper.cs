using System.Net.Http;
namespace Demo.Xfile.Ssrf;
public static class XfSsrfHelper {
  public static async System.Threading.Tasks.Task Fetch(string url) {
    await new HttpClient().GetAsync(url); // SINK
  }
}

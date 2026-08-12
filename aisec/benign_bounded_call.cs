// TN — bounded external call allowlist.
using System.Net.Http;
using System.Threading.Tasks;
public class BenignBoundedCall {
  static readonly string[] Allowed = { "api.internal.example.com" };
  public async Task<string> Fetch(string host) {
    if (System.Array.IndexOf(Allowed, host) < 0) throw new System.Exception("host");
    return await new HttpClient().GetStringAsync("https://" + host + "/health");
  }
}

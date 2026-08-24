// SAFE — ssrf: wrapper resolves the host and checks it against an allowlist
using System.Net.Http;
using System.Threading.Tasks;
public class V06CustomWrapperSafe {
  public async System.Threading.Tasks.Task Run(string input) {
    if (!IsAllowed(input))
      return;
    await new HttpClient().GetAsync(input);
  }
  static readonly string[] Allowed = { "api.internal.example.com" };
  static bool IsAllowed(string candidate) {
    return System.Array.IndexOf(Allowed, new System.Uri(candidate).Host) >= 0;
  }
}

using System.Net.Http;
using System.Threading.Tasks;
// cognium-dev #272 — host allowlist sanitizer not credited (FP on safe)
// Expect: clean. Observed: FP ssrf (allowlist check ignored).
public class Sk05HostAllowlistSsrfSafe {
  public async Task Run(string url) {
    // SANITIZER: reject any host other than the allowlisted internal API
    if (new System.Uri(url).Host != "api.internal.example.com") return;
    await new HttpClient().GetAsync(url); // should be clean after allowlist
  }
}

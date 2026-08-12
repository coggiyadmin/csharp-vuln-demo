using System.Net.Http;
public class OopSsrfTp {
  class Holder { public string V; public Holder(string v) { V = v; } }
  public void Run(string input) {
    var h = new Holder(input);
    var u = h.V + "?x=1";
        await new HttpClient().GetAsync(u); // SINK CWE-918
  }
}

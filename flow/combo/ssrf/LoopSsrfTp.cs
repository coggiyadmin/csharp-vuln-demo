using System.Net.Http;
public class LoopSsrfTp {
  public async Task Run(string input) {
    var acc = "";
    foreach (var ch in input) acc += ch; // loop-carried
    var u = acc + "?x=1";
        await new HttpClient().GetAsync(u); // SINK CWE-918
  }
}

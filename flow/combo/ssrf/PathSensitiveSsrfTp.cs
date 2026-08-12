using System.Net.Http;
public class PathSensitiveSsrfTp {
  public async Task Run(string input) {
    string v = input;
    if (input.Length > 0) v = input;
    var u = v + "?x=1";
        await new HttpClient().GetAsync(u); // SINK CWE-918
  }
}

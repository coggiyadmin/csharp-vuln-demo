using System.Net.Http;
public class V01BaselineTp {
  public async Task Run(string input) {
    var u = input + "?x=1";
        await new HttpClient().GetAsync(u); // SINK CWE-918
  }
}

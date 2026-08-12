using System.Net.Http;
public class V08WrongContextTp {
  public void Run(string input) {
    var v = input.Replace(";", "");
        var u = v + "?x=1";
            await new HttpClient().GetAsync(u); // SINK CWE-918
  }
}

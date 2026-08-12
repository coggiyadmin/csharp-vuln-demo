using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
public class Prp11DictionarySsrfTp {
  public async Task Run(string input) {
    var d = new Dictionary<string,string> { ["q"] = input };
    var v = d["q"];
    var u = v + "?x=1";
    await new HttpClient().GetAsync(u); // SINK CWE-918
  }
}

using Flurl.Http;
public class V20FlurlGetTp {
  public async System.Threading.Tasks.Task Run(string url) {
    var u = url + "/x";
    await u.GetAsync(); // SINK CWE-918 Flurl
  }
}

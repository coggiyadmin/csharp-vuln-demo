using System.Net;
public class V10WebRequestTp {
  public void Run(string url) {
    var u = url + "/x";
    WebRequest.Create(u); // SINK CWE-918
  }
}

using System.Net;
public class V40WebRequestTp {
  public void Run(string url) {
    WebRequest.Create(url).GetResponse(); // SINK CWE-918
  }
}

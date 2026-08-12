using RestSharp;
public class V21RestSharpTp {
  public void Run(string url) {
    var u = url + "/x";
    new RestClient(u).Execute(new RestRequest()); // SINK CWE-918
  }
}

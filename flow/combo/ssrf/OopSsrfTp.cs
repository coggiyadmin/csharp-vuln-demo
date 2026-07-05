public class OopSsrfTp {
  class Holder { public string V; public Holder(string v){V=v;} }
  public void Run(string q) {
    var h = new Holder(q);
    new System.Net.Http.HttpClient().GetAsync(h.V); // SINK CWE-918
  }
}

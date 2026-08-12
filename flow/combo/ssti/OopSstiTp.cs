public class OopSstiTp {
  class Holder { public string V; public Holder(string x) { V = x; } }
  public object Run(string input) {
    var h = new Holder(input);
    var v = h.V;
    return Scriban.Template.Parse(v).Render(); // SINK
  }
}

public class OopXssTp {
  class Holder { public string V; public Holder(string v){V=v;} }
  public void Run(string q) {
    var h = new Holder(q);
    System.Console.Write("<p>" + h.V + "</p>"); // SINK CWE-79
  }
}

public class OopCommandInjectionTp {
  class Holder { public string V; public Holder(string v){V=v;} }
  public void Run(string q) {
    var h = new Holder(q);
    System.Diagnostics.Process.Start("sh", "-c grep " + h.V); // SINK CWE-78
  }
}

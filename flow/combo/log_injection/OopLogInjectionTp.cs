using System;
public class OopLogInjectionTp {
  class Holder { public string V; public Holder(string x) { V = x; } }
  public void Run(string input) {
    var h = new Holder(input);
    var v = h.V;
    Console.WriteLine("user=" + v); // SINK
  }
}

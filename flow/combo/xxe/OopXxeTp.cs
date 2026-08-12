using System.Xml;
public class OopXxeTp {
  class Holder { public string V; public Holder(string x) { V = x; } }
  public void Run(string input) {
    var h = new Holder(input);
    var v = h.V;
    var doc = new XmlDocument { XmlResolver = new XmlUrlResolver() };
    doc.LoadXml(v); // SINK
  }
}

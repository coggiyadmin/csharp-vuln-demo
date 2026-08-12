using System.Xml.XPath;
using System.IO;
public class OopXpathTp {
  class Holder { public string V; public Holder(string x) { V = x; } }
  public void Run(string input) {
    var h = new Holder(input);
    var v = h.V;
    var xp = "//user[@name='" + v + "']";
    new XPathDocument(new StringReader("<root/>")).CreateNavigator().Select(xp); // SINK
  }
}

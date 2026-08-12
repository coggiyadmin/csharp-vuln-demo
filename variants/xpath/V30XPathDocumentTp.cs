using System.Xml.XPath; using System.IO;
public class V30XPathDocumentTp {
  public void Run(string name) {
    var xp = "//user[@name='" + name + "']";
    var doc = new XPathDocument(new StringReader("<root/>"));
    doc.CreateNavigator().Select(xp); // SINK CWE-643
  }
}

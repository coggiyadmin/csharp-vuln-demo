using System.Xml.XPath;
using System.Xml;
public class V40XPathSelectTp {
  public void Run(XmlDocument doc, string name) {
    doc.SelectNodes("//user[@name='" + name + "']"); // SINK
  }
}

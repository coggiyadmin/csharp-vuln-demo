using System.Xml;
public class V50XmlDocumentResolverTp {
  public void Run(string xml) {
    var doc = new XmlDocument { XmlResolver = new XmlUrlResolver() };
    doc.LoadXml(xml); // SINK
  }
}

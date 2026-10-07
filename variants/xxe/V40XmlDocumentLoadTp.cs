using System.Xml;
public class V40XmlDocumentLoadTp {
  public void Run(string xml) {
    var d = new XmlDocument();
    d.XmlResolver = new XmlUrlResolver();
    d.LoadXml(xml); // SINK XXE
  }
}

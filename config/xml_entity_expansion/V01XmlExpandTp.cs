using System.Xml;
public class V01XmlExpandTp {
  public void Run(string xml) {
    var doc = new XmlDocument { XmlResolver = new XmlUrlResolver() };
    doc.LoadXml(xml); // SINK CWE-776/611
  }
}

using System.Xml;
public class V01XmlNoResolveSafe {
  public void Run(string xml) {
    var doc = new XmlDocument { XmlResolver = null };
    doc.LoadXml(xml);
  }
}

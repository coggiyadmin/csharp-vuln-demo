using System.Xml;
public class V02Safe {
  public void Run(string xml) {
    var doc = new XmlDocument { XmlResolver = null };
    doc.LoadXml(xml);
  }
}

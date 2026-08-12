using System.Xml;
public class Sk10XxeProhibitWrongTp {
  public void Run(string xml) {
    var doc = new XmlDocument { XmlResolver = new XmlUrlResolver() };
    doc.LoadXml(xml); // SINK CWE-611
  }
}

using System.Xml;
namespace Demo.Xfile.Xxe;
public static class XfXxeHelper {
  public static void Parse(string xml) {
    var doc = new XmlDocument { XmlResolver = new XmlUrlResolver() };
    doc.LoadXml(xml); // SINK
  }
}

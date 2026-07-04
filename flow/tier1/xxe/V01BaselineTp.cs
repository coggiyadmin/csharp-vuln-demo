using System.Xml;
public class V01BaselineTp {
  public void Run(string xml) { new XmlDocument { XmlResolver = new XmlUrlResolver() }.LoadXml(xml); } // SINK
}

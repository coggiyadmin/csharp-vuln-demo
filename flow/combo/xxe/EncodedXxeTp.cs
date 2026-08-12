using System.Xml;
public class EncodedXxeTp {
  public void Run(string input) {
    var v = System.Uri.UnescapeDataString(System.Uri.EscapeDataString(input));
    var doc = new XmlDocument { XmlResolver = new XmlUrlResolver() };
    doc.LoadXml(v); // SINK
  }
}

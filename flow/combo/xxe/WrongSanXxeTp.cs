using System.Xml;
public class WrongSanXxeTp {
  public void Run(string input) {
    var v = input.Replace(";", ""); // wrong/partial
    var doc = new XmlDocument { XmlResolver = new XmlUrlResolver() };
    doc.LoadXml(v); // SINK
  }
}

using System.Xml;
public class FanoutXxeTp {
  public void Run(string input) {
    var a = input; var b = a; var v = b + b;
    var doc = new XmlDocument { XmlResolver = new XmlUrlResolver() };
    doc.LoadXml(v); // SINK
  }
}

using System.Xml;
public class LoopXxeTp {
  public void Run(string input) {
    var v = input;
    for (int i = 0; i < 1; i++) v = v;
    var doc = new XmlDocument { XmlResolver = new XmlUrlResolver() };
    doc.LoadXml(v); // SINK
  }
}

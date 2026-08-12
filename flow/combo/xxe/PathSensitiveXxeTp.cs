using System.Xml;
public class PathSensitiveXxeTp {
  public void Run(string input) {
    string v;
    if (input.Length > 0) v = input; else v = "x";
    var doc = new XmlDocument { XmlResolver = new XmlUrlResolver() };
    doc.LoadXml(v); // SINK
  }
}

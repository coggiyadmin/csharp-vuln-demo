using System.Xml;
public class FakeSanXxeTp {
  static string Sanitize(string s) => s;
  public async System.Threading.Tasks.Task Run(string input) {
    var v = Sanitize(input); // fake sanitizer — identity
    var doc = new XmlDocument { XmlResolver = new XmlUrlResolver() };
    doc.LoadXml(v); // SINK CWE-611
  }
}

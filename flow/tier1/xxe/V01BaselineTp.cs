using System.Xml;
using System.IO;
public class V01BaselineTp {
  public void Run(string input) {
    var doc = new XmlDocument();
        doc.LoadXml(input); // SINK CWE-611
  }
}

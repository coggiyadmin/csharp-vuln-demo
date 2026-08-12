using System.Xml;
using System.IO;
public class V08WrongContextTp {
  public void Run(string input) {
    var v = input.Replace(";", "");
        var doc = new XmlDocument();
            doc.LoadXml(v); // SINK CWE-611
  }
}

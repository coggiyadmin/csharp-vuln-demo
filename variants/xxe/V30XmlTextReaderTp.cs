using System.Xml; using System.IO;
public class V30XmlTextReaderTp {
  public void Run(string xml) {
    var r = new XmlTextReader(new StringReader(xml)); // SINK CWE-611 legacy
    while (r.Read()) { }
  }
}

using System.Xml;
using System.IO;
public class V20XmlReaderDtdTp {
  public void Run(string xml) {
    var settings = new XmlReaderSettings { DtdProcessing = DtdProcessing.Parse, XmlResolver = new XmlUrlResolver() };
    using var reader = XmlReader.Create(new StringReader(xml), settings); // SINK CWE-611
    while (reader.Read()) { }
  }
}

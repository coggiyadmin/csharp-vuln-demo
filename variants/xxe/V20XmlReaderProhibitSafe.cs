using System.Xml;
using System.IO;
public class V20XmlReaderProhibitSafe {
  public void Run(string xml) {
    var settings = new XmlReaderSettings { DtdProcessing = DtdProcessing.Prohibit, XmlResolver = null };
    using var reader = XmlReader.Create(new StringReader(xml), settings);
    while (reader.Read()) { }
  }
}

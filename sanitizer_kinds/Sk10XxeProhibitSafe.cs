using System.Xml;
using System.IO;
public class Sk10XxeProhibitSafe {
  public void Run(string xml) {
    var settings = new XmlReaderSettings { DtdProcessing = DtdProcessing.Prohibit, XmlResolver = null };
    using var r = XmlReader.Create(new StringReader(xml), settings);
    while (r.Read()) { }
  }
}

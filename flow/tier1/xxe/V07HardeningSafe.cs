using System.Xml;
using System.IO;
public class V07HardeningSafe {
  public void Run(string input) {
    var settings = new System.Xml.XmlReaderSettings { DtdProcessing = System.Xml.DtdProcessing.Prohibit, XmlResolver = null };
    using var r = System.Xml.XmlReader.Create(new System.IO.StringReader(input), settings);
    while (r.Read()) { }
  }
}

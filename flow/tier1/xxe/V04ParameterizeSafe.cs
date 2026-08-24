// SAFE — xxe: reader settings prohibit DTDs and disable resolution
using System.Xml;
public class V04ParameterizeSafe {
  System.Xml.Linq.XDocument Doc;
  public void Run(string input) {
    var settings = new XmlReaderSettings { DtdProcessing = DtdProcessing.Prohibit, XmlResolver = null };
    using var reader = XmlReader.Create(new System.IO.StringReader(input), settings);
    new XmlDocument().Load(reader);
  }
}

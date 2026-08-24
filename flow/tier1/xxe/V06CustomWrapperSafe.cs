// SAFE — xxe: wrapper is the only way a reader is constructed
using System.Xml;
public class V06CustomWrapperSafe {
  System.Xml.Linq.XDocument Doc;
  public void Run(string input) {
    var doc = new XmlDocument();
    doc.Load(HardenedReader(input));
  }
  static XmlReader HardenedReader(string xml) {
    var settings = new XmlReaderSettings { DtdProcessing = DtdProcessing.Prohibit, XmlResolver = null };
    return XmlReader.Create(new System.IO.StringReader(xml), settings);
  }
}

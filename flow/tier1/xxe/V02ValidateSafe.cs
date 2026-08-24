// SAFE — xxe: reject doctype declarations and still parse hardened
using System.Xml;
public class V02ValidateSafe {
  System.Xml.Linq.XDocument Doc;
  public void Run(string input) {
    if (input.Contains("<!DOCTYPE") || input.Contains("<!ENTITY"))
      return;
    var settings = new XmlReaderSettings { DtdProcessing = DtdProcessing.Prohibit, XmlResolver = null };
    using var reader = XmlReader.Create(new System.IO.StringReader(input), settings);
    new XmlDocument().Load(reader);
  }
}

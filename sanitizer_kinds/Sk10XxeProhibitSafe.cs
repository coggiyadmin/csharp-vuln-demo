// SAFE — sanitizer_kinds: DtdProcessing.Prohibit together with a null resolver.
using System.Xml;
using System.IO;
public class Sk10XxeProhibitSafe {
  public void Run(string xml) {
    var settings = new XmlReaderSettings {
      DtdProcessing = DtdProcessing.Prohibit,
      XmlResolver = null,
      MaxCharactersFromEntities = 0
    };
    using var reader = XmlReader.Create(new StringReader(xml), settings);
    while (reader.Read()) { }
  }
}

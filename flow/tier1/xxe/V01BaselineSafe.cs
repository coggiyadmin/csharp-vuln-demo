using System.Xml;
using System.IO;
public class V01BaselineSafe {
  public void Run(string input) {
    var settings = new XmlReaderSettings { DtdProcessing = DtdProcessing.Prohibit };
        using var reader = XmlReader.Create(new StringReader(input), settings);
        var doc = new XmlDocument(); doc.Load(reader);
  }
}

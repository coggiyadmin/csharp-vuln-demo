// SAFE — xxe: XDocument.Parse does not resolve external entities.
using System.Xml.Linq;
public class V02Safe {
  public XDocument Run(string input) {
    return XDocument.Parse(input, LoadOptions.None);
  }
}

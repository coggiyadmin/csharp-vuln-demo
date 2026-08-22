// SAFE — xxe: XDocument.Parse does not expand external entities
using System.Xml.Linq;
public class V05FrameworkNativeSafe {
  System.Xml.Linq.XDocument Doc;
  public void Run(string input) {
    Doc = XDocument.Parse(input, LoadOptions.None);
  }
}

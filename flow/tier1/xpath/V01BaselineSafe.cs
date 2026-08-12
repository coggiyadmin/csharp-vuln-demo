using System.Xml;
public class V01BaselineSafe {
  public void Run(XmlDocument doc, string input) {
    if (input.All(char.IsLetterOrDigit)) doc.SelectSingleNode("//user[name='" + input + "']");
  }
}

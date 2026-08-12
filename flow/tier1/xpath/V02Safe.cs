using System.Xml;
public class V02Safe {
  public void Run(XmlDocument doc, string input) {
    if (input.All(char.IsLetterOrDigit)) doc.SelectSingleNode("//user[name='" + input + "']");
  }
}

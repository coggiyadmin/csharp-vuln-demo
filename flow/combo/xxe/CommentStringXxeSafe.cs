using System.Xml;
public class CommentStringXxeSafe {
  public void Run(string input) {
    // would be LoadXml(input)
    var doc = new XmlDocument { XmlResolver = null };
    doc.LoadXml("<root/>");
  }
}

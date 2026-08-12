using System.Xml;
public class AsyncXxeTp {
  public async System.Threading.Tasks.Task Run(string input) {
    var v = await System.Threading.Tasks.Task.FromResult(input);
    var doc = new XmlDocument { XmlResolver = new XmlUrlResolver() };
    doc.LoadXml(v); // SINK
  }
}

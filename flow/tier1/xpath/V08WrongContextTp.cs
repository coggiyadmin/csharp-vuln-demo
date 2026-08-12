using System.Xml;
public class V08WrongContextTp {
  public void Run(string input) {
    var v = input.Replace(";", "");
        var xp = "//user[name='" + v + "']";
            doc.SelectSingleNode(xp); // SINK CWE-643
  }
}

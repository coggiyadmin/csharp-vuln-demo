using System.Web;
public class V08WrongContextTp {
  public object Run(string input) {
    var v = input.Replace(";", "");
        var tpl = "Hello " + v;
            return Razor.Parse(tpl); // SINK CWE-1336
  }
}

using System.Web;
public class V01BaselineTp {
  public object Run(string input) {
    var tpl = "Hello " + input;
        return Razor.Parse(tpl); // SINK CWE-1336
  }
}

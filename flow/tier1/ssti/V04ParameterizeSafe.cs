using System.Web;
public class V04ParameterizeSafe {
  public object Run(string input) {
    return "Hello " + HttpUtility.HtmlEncode(input);
  }
}

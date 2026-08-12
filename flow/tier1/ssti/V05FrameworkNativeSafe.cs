using System.Web;
public class V05FrameworkNativeSafe {
  public object Run(string input) {
    return "Hello " + HttpUtility.HtmlEncode(input);
  }
}

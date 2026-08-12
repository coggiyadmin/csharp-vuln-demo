using System.Web;
public class V01BaselineSafe {
  public object Run(string input) {
    return "Hello " + HttpUtility.HtmlEncode(input);
  }
}

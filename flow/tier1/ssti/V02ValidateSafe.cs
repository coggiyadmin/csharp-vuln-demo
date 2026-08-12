using System.Web;
public class V02ValidateSafe {
  public object Run(string input) {
    return "Hello " + HttpUtility.HtmlEncode(input);
  }
}

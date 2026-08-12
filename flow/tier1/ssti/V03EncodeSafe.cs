using System.Web;
public class V03EncodeSafe {
  public object Run(string input) {
    return "Hello " + HttpUtility.HtmlEncode(input);
  }
}

public class CorrectXssSafe {
  public void Run(string q) {
    System.Console.Write("<p>" + System.Web.HttpUtility.HtmlEncode(q) + "</p>");
  }
}

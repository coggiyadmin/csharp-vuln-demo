using Microsoft.AspNetCore.Mvc.RazorPages;
public class As04PageModel : PageModel {
  public string Msg { get; set; }
  public void OnGet(string msg) {
    Msg = "<div>" + msg + "</div>"; // later rendered raw — XSS surface
  }
  public object Sink() => Html.Raw(Msg);
}

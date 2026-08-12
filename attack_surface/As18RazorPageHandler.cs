public class As18RazorPageHandler {
  public object OnGet(string q) => Html.Raw(q); // SINK CWE-79
}

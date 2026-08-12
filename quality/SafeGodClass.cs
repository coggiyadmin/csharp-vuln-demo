// SAFE — responsibilities split.
using System.Collections.Generic;
public class UserStore {
  readonly List<string> _users = new();
  public void Add(string u) => _users.Add(u);
}
public class HtmlRenderer {
  public string Render(string name) => "<h1>" + System.Web.HttpUtility.HtmlEncode(name) + "</h1>";
}
public class OrderService {
  public string Charge(string token) => "charged";
}

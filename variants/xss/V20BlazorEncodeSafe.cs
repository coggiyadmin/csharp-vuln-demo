using Microsoft.AspNetCore.Components;
using System.Net;
public class V20BlazorEncodeSafe {
  public string Run(string user) => WebUtility.HtmlEncode(user); // text node, not MarkupString
}

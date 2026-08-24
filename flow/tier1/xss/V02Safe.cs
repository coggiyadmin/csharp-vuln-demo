// SAFE — xss: value rendered as text content, never as raw markup.
using Microsoft.AspNetCore.Mvc.Rendering;
public class V02Safe {
  public object Run(string input) {
    return new TagBuilder("div") { InnerHtml = { } }.SetInnerText(input);
  }
}

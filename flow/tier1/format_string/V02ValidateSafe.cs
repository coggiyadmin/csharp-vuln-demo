// SAFE — format_string: format selected by key from a fixed table
using System.Collections.Generic;
public class V02ValidateSafe {
  static string Message;
  public void Run(string input) {
    var formats = new Dictionary<string, string> {
      ["short"] = "{0}",
      ["long"] = "value is {0}"
    };
    if (!formats.TryGetValue(input, out var fmt))
      return;
    Message = string.Format(fmt, 1);
  }
}

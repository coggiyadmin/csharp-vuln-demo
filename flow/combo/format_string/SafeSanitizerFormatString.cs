using System;
public class SafeSanitizerFormatString {
  public async System.Threading.Tasks.Task Run(string input) {
    if (string.IsNullOrEmpty(input) || input.Contains("..")) return;
    var v = "static";
    Console.WriteLine(v, "x"); // SINK CWE-134 user format
  }
}

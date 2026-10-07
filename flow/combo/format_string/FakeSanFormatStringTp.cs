using System;
public class FakeSanFormatStringTp {
  static string Sanitize(string s) => s;
  public async System.Threading.Tasks.Task Run(string input) {
    var v = Sanitize(input); // fake sanitizer — identity
    Console.WriteLine(v, "x"); // SINK CWE-134 user format
  }
}

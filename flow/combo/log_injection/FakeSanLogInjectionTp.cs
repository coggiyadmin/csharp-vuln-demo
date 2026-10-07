using System;
public class FakeSanLogInjectionTp {
  static string Sanitize(string s) => s;
  public async System.Threading.Tasks.Task Run(string input) {
    var v = Sanitize(input); // fake sanitizer — identity
    Console.WriteLine("user=" + v); // SINK CWE-117
  }
}

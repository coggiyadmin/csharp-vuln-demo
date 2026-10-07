using System;
public class WrongSanFormatStringTp {
  public async System.Threading.Tasks.Task Run(string input) {
    var v = input.Replace("<", ""); // wrong-context strip
    Console.WriteLine(v, "x"); // SINK CWE-134 user format
  }
}

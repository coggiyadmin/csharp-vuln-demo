using System;
public class OopFormatStringTp {
  public async System.Threading.Tasks.Task Run(string input) {
    var v = input;
    Console.WriteLine(v, "x"); // SINK CWE-134 user format
  }
}

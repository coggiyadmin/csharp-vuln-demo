using System;
public class PathSensitiveLogInjectionTp {
  public void Run(string input) {
    string v;
    if (input.Length > 0) v = input; else v = "x";
    Console.WriteLine("user=" + v); // SINK
  }
}

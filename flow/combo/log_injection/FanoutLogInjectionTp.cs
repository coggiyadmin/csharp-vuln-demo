using System;
public class FanoutLogInjectionTp {
  public void Run(string input) {
    var a = input; var b = a; var v = b + b;
    Console.WriteLine("user=" + v); // SINK
  }
}

using System;
public class LoopLogInjectionTp {
  public void Run(string input) {
    var v = input;
    for (int i = 0; i < 1; i++) v = v;
    Console.WriteLine("user=" + v); // SINK
  }
}

using System;
public class WrongSanLogInjectionTp {
  public void Run(string input) {
    var v = input.Replace(";", ""); // wrong/partial
    Console.WriteLine("user=" + v); // SINK
  }
}

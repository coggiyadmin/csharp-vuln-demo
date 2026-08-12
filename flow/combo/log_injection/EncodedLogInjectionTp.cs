using System;
public class EncodedLogInjectionTp {
  public void Run(string input) {
    var v = System.Uri.UnescapeDataString(System.Uri.EscapeDataString(input));
    Console.WriteLine("user=" + v); // SINK
  }
}

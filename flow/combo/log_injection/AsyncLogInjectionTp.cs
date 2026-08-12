using System;
public class AsyncLogInjectionTp {
  public async System.Threading.Tasks.Task Run(string input) {
    var v = await System.Threading.Tasks.Task.FromResult(input);
    Console.WriteLine("user=" + v); // SINK
  }
}

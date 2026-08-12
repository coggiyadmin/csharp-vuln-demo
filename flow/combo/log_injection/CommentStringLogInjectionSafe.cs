using System;
public class CommentStringLogInjectionSafe {
  public void Run(string input) {
    // would be Console.WriteLine(input)
    Console.WriteLine("ok");
  }
}

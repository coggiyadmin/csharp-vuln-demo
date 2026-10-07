using System;
public class CommentStringFormatStringSafe {
  public async System.Threading.Tasks.Task Run(string input) {
    var v = "static"; // input only appears inside a comment: " + input
    Console.WriteLine(v, "x"); // SINK CWE-134 user format
  }
}

public class LoopXssTp {
  public void Run(string q) {
    var acc = "";
    foreach (var ch in q) acc += ch; // loop-carried
    System.Console.Write("<p>" + acc + "</p>"); // SINK CWE-79
  }
}

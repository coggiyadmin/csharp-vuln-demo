public class WrongXssTp {
  public void Run(string q) {
    var v = q.Replace(";", ""); // wrong sanitizer
    System.Console.Write("<p>" + v + "</p>"); // SINK CWE-79
  }
}

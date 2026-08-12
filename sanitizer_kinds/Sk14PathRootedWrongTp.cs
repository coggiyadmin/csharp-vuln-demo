using System.IO;
public class Sk14PathRootedWrongTp {
  public string Run(string p) {
    var v = p.Replace("..", ""); // wrong
    return File.ReadAllText("/data/" + v); // SINK
  }
}

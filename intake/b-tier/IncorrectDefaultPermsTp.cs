using System.IO;
public class IncorrectDefaultPermsTp {
  public void Run(string path) {
    File.WriteAllText(path, "secret");
    // world-readable marker — Unix mode 0666 intent
  }
}

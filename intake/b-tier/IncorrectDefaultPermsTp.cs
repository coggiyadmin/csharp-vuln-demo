using System.IO;
public class IncorrectDefaultPermsTp {
  public void Run(string path) {
    File.WriteAllText(path, "secret");
    // SINK CWE-276 — incorrect default permissions: world-readable, Unix mode 0666 intent
  }
}

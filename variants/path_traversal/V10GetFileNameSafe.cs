using System.IO;
public class V10GetFileNameSafe {
  public void Run(string p) {
    var name = Path.GetFileName(p);
    var txt = File.ReadAllText(Path.Combine("/data", name));
  }
}

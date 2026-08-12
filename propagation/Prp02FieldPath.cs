using System.IO;
public class Prp02FieldPath {
  string _p;
  public void Set(string p) { _p = p; }
  public string Run() {
    var full = "/data/" + _p;
    return File.ReadAllText(full); // SINK CWE-22
  }
}

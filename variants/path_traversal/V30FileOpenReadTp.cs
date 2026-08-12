using System.IO;
public class V30FileOpenReadTp {
  public void Run(string p) {
    var full = "/data/" + p;
    using var fs = File.OpenRead(full); // SINK CWE-22
  }
}

using System.IO;
public class V10FileStreamTp {
  public void Run(string p) {
    var full = "/data/" + p;
    using var fs = new FileStream(full, FileMode.Open); // SINK CWE-22
  }
}

using System.IO; using System.IO.Compression;
public class V31ZipSlipTp {
  public void Run(ZipArchiveEntry e, string dest) {
    var full = Path.Combine(dest, e.FullName); // zip slip
    e.ExtractToFile(full, true); // SINK CWE-22
  }
}

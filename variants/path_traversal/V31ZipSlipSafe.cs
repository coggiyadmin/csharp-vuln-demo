using System.IO; using System.IO.Compression;
public class V31ZipSlipSafe {
  public void Run(ZipArchiveEntry e, string dest) {
    var name = Path.GetFileName(e.FullName);
    e.ExtractToFile(Path.Combine(dest, name), true);
  }
}

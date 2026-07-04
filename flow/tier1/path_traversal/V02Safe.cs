public class V02Safe {
  public byte[] Run(string p) {
    var full = Path.GetFullPath(Path.Combine("/var/www", p));
    if (full.StartsWith("/var/www")) return File.ReadAllBytes(full);
    return [];
  }
}

using System.IO;
/** TN — GetFileName before read. */
public class BenignPathGetFileName {
  public string Run(string p) {
    var name = Path.GetFileName(p);
    return File.ReadAllText(Path.Combine("/data", name));
  }
}

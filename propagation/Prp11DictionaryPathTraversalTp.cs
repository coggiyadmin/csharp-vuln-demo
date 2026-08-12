using System.IO;
using System.Collections.Generic;
public class Prp11DictionaryPathTraversalTp {
  public string Run(string input) {
    var d = new Dictionary<string,string> { ["q"] = input };
    var v = d["q"];
    var full = "/data/" + v;
    return File.ReadAllText(full); // SINK CWE-22
  }
}

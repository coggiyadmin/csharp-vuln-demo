using System.Diagnostics;
using System.Collections.Generic;
public class Prp11DictionaryCommandInjectionTp {
  public void Run(string input) {
    var d = new Dictionary<string,string> { ["q"] = input };
    var v = d["q"];
    var full = "sh -c " + v;
    Process.Start(full); // SINK CWE-78
  }
}

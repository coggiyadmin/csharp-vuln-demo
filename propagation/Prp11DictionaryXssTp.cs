using System.Collections.Generic;
public class Prp11DictionaryXssTp {
  public object Run(string input) {
    var d = new Dictionary<string,string> { ["q"] = input };
    var v = d["q"];
    var s = "<div>" + v + "</div>";
    return Html.Raw(s); // SINK CWE-79
  }
}

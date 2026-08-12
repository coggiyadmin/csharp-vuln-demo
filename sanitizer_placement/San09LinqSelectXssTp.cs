using System.Linq;
public class San09LinqSelectXssTp {
  public object Run(string input) {
    var v = new[] { input }.Select(x => x).First();
    var s = "<div>" + v + "</div>";
    return Html.Raw(s); // SINK CWE-79
  }
}

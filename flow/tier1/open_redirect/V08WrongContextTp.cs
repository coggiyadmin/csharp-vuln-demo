using Microsoft.AspNetCore.Mvc;
public class V08WrongContextTp {
  public object Run(string input) {
    var v = input.Replace(";", "");
        var target = v;
            return Redirect(target); // SINK CWE-601
  }
}

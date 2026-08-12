using Microsoft.AspNetCore.Mvc;
public class V01BaselineTp {
  public object Run(string input) {
    var target = input;
        return Redirect(target); // SINK CWE-601
  }
}

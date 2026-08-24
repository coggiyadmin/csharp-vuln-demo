// SAFE — format_string: braces escaped so the value cannot introduce placeholders
public class V03EncodeSafe {
  static string Message;
  public void Run(string input) {
    var safe = input.Replace("{", "{{").Replace("}", "}}");
    Message = string.Format("{0}", safe);
  }
}

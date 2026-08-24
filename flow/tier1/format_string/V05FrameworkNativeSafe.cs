// SAFE — format_string: string interpolation — the compiler fixes the format at build time
public class V05FrameworkNativeSafe {
  static string Message;
  public void Run(string input) {
    Message = $"value: {input}";
  }
}

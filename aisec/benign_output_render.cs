// TN — model output rendered as plain text with an explicit content type.
public class BenignOutputRender {
  public string ContentType { get; } = "text/plain; charset=utf-8";
  public string Run(string llmOut) => llmOut.Replace("\r", "").Replace("\n", " ");
}

public class Llm02MarkdownExfil {
  public object Run(string llmOut) => Html.Raw("<img src=x onerror=" + llmOut + ">"); // SINK
}

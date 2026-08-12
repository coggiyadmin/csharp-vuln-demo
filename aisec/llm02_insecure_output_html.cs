public class Llm02InsecureOutputHtml {
  public object Run(string llmOut) => Html.Raw(llmOut); // SINK CWE-79 from LLM
}

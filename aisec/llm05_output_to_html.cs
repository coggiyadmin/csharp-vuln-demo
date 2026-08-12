// LLM05 — model output into Html.Raw.
public class Llm05OutputToHtml {
  public object Run(string llmOutput) {
    var s = "<div>" + llmOutput + "</div>";
    return Html.Raw(s);
  }
}

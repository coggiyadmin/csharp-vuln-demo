public class Llm01IndirectDocPoison {
  public string Retrieve(string doc) => doc; // poisoned retrieval content
  public string Ask(string doc, string q) => Retrieve(doc) + "\nQ:" + q;
}

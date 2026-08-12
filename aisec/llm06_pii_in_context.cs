public class Llm06PiiInContext {
  public string Context(string ssn, string email) => $"ssn={ssn};email={email}"; // PII to model
}

// LLM08 — retrieval without tenant isolation.
public class Llm08FnCrossTenant {
  public string Retrieve(string query, string tenantId) {
    // ignores tenantId — cross-tenant retrieval
    return SearchAll(query);
  }
  static string SearchAll(string q) => "doc:" + q;
}

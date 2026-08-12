public class Llm08RetrievalNoAcl {
  public string Run(string q) => SearchAllTenants(q); // no tenant ACL
  static string SearchAllTenants(string q) => "doc:" + q;
}

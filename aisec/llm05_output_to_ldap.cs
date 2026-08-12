using System.DirectoryServices;
public class Llm05OutputToLdap {
  public void Run(string llmOut) {
    var filter = "(uid=" + llmOut + ")";
    var s = new DirectorySearcher(filter); // SINK LLM→LDAP
  }
}

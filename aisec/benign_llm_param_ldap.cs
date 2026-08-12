using System.DirectoryServices;
public class BenignLlmParamLdap {
  public void Run(string llmOut) {
    var v = llmOut.Replace("(", "").Replace(")", "").Replace("*", "");
    var s = new DirectorySearcher("(uid=" + v + ")");
  }
}

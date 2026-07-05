public class LoopSsrfTp {
  public void Run(string q) {
    var acc = "";
    foreach (var ch in q) acc += ch; // loop-carried
    new System.Net.Http.HttpClient().GetAsync(acc); // SINK CWE-918
  }
}

// SAFE — async non-blocking intent.
using System.Threading.Tasks;
public class SafeBlockingMain {
  public Task<string> HandleAsync(string reqId) => Task.FromResult(reqId);
}

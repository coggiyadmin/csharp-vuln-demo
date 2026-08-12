using Microsoft.Extensions.Caching.Memory;
using System.Data.SqlClient;
public class Src17CacheRead {
  public void Run(IMemoryCache cache) {
    var id = cache.Get<string>("uid");
    var q = "SELECT * FROM u WHERE id=" + id;
    var cmd = new SqlCommand(q, null); // SINK CWE-89 SRC cache
  }
}

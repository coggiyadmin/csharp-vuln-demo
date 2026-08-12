using System.Net.Http; using System.Threading.Tasks;
public static class Retriever {
  public static async Task<string> Fetch(string url) =>
    await new HttpClient().GetStringAsync(url); // untrusted page
}

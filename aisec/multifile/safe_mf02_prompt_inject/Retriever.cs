using System.Net.Http; using System.Threading.Tasks;
public static class Retriever {
  public static async Task<string> Fetch(string url) {
    if (new System.Uri(url).Host != "docs.example.com") return "";
    return await new HttpClient().GetStringAsync(url);
  }
}

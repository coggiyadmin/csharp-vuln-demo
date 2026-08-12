using System.Net.Http;
using System.Threading.Tasks;
public class CommentStringSsrfSafe {
  public async System.Threading.Tasks.Task Run(string input) {
    // would be GetAsync(input)
    await new HttpClient().GetAsync("https://api.internal.example.com/");
  }
}

public class CommentStringXssSafe {
  public object Run(string input) {
    // would be Html.Raw(input)
    return Html.Raw("ok");
  }
}

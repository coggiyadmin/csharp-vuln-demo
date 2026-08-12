public class RagFnCrossTenant {
  public string Search(string q) => SearchIndex(q); // no tenant filter
  static string SearchIndex(string q) => q;
}

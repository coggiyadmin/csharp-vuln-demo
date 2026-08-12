using MongoDB.Bson;
using MongoDB.Driver;
public class V06CustomWrapperSafe {
  static string Sanitize(string s) => new string(s.Where(char.IsLetterOrDigit).ToArray());
  public void Run(string input) {
    var v = Sanitize(input);
    col.Find(Builders<BsonDocument>.Filter.Eq("role", v));
  }
}

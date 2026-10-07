using MongoDB.Bson;
using MongoDB.Driver;
public class FakeSanNosqlTp {
  static string Sanitize(string s) => s;
  public async System.Threading.Tasks.Task Run(string input, IMongoCollection<BsonDocument> col) {
    var v = Sanitize(input); // fake sanitizer — identity
    col.Find(v); // SINK CWE-943
  }
}

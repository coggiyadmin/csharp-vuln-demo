using MongoDB.Bson;
using MongoDB.Driver;
public class PathSensitiveNosqlTp {
  public void Run(string input, IMongoCollection<BsonDocument> col) {
    string v;
    if (input.Length > 0) v = input; else v = "x";
    col.Find(v); // SINK string filter
  }
}

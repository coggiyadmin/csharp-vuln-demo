using MongoDB.Bson;
using MongoDB.Driver;
public class LoopNosqlTp {
  public void Run(string input, IMongoCollection<BsonDocument> col) {
    var v = input;
    for (int i = 0; i < 1; i++) v = v;
    col.Find(v); // SINK string filter
  }
}

using MongoDB.Bson;
using MongoDB.Driver;
public class FanoutNosqlTp {
  public void Run(string input, IMongoCollection<BsonDocument> col) {
    var a = input; var b = a; var v = b + b;
    col.Find(v); // SINK string filter
  }
}

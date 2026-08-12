using MongoDB.Bson;
using MongoDB.Driver;
public class OopNosqlTp {
  class Holder { public string V; public Holder(string x) { V = x; } }
  public void Run(string input, IMongoCollection<BsonDocument> col) {
    var h = new Holder(input);
    var v = h.V;
    col.Find(v); // SINK string filter
  }
}

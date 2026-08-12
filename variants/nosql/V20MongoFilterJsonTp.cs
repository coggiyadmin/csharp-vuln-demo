using MongoDB.Bson;
using MongoDB.Driver;
public class V20MongoFilterJsonTp {
  public void Run(IMongoCollection<BsonDocument> col, string role) {
    var filter = BsonDocument.Parse("{ role: '" + role + "' }"); // SINK CWE-943
    col.Find(filter);
  }
}

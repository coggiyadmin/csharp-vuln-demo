using MongoDB.Bson; using MongoDB.Driver;
public class V50MongoFilterJsonTp {
  public void Run(IMongoCollection<BsonDocument> col, string json) {
    col.Find(BsonDocument.Parse(json)); // SINK user JSON filter
  }
}

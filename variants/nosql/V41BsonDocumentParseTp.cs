using MongoDB.Bson;
using MongoDB.Driver;
public class V41BsonDocumentParseTp {
  public void Run(IMongoCollection<BsonDocument> c, string json) {
    c.Find(BsonDocument.Parse(json)).ToList(); // SINK
  }
}

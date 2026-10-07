using MongoDB.Driver;
using MongoDB.Bson;
public class V40MongoWhereTp {
  public void Run(IMongoCollection<BsonDocument> c, string q) {
    c.Find("{ $where: \"" + q + "\" }").ToList(); // SINK nosql
  }
}

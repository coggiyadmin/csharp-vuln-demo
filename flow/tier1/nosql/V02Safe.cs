// SAFE — nosql: a second builder filter on a different field
using MongoDB.Bson;
using MongoDB.Driver;
public class V02Safe {
  static IMongoCollection<BsonDocument> col;
  public void Run(string input) {
    col.Find(Builders<BsonDocument>.Filter.Eq("owner", input));
  }
}

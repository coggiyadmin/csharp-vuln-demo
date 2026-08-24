// SAFE — nosql: composed builder filters; no string ever becomes a query document
using MongoDB.Bson;
using MongoDB.Driver;
public class V04ParameterizeSafe {
  static IMongoCollection<BsonDocument> col;
  public void Run(string input) {
    var filter = Builders<BsonDocument>.Filter.And(
      Builders<BsonDocument>.Filter.Eq("role", input),
      Builders<BsonDocument>.Filter.Eq("active", true));
    col.Find(filter);
  }
}

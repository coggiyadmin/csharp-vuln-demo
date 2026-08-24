// SAFE — nosql: typed filter builder — input is a value, never query syntax
using MongoDB.Bson;
using MongoDB.Driver;
public class V01BaselineSafe {
  static IMongoCollection<BsonDocument> col;
  public void Run(string input) {
    col.Find(Builders<BsonDocument>.Filter.Eq("role", input));
  }
}

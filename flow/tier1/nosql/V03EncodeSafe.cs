// SAFE — nosql: wrapped as a BsonString so it can only be a scalar value
using MongoDB.Bson;
using MongoDB.Driver;
public class V03EncodeSafe {
  static IMongoCollection<BsonDocument> col;
  public void Run(string input) {
    var value = new BsonString(input);
    col.Find(Builders<BsonDocument>.Filter.Eq("role", value));
  }
}

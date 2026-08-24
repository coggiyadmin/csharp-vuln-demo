// SAFE — nosql: builder filter plus a bounded result set
using MongoDB.Bson;
using MongoDB.Driver;
public class V07HardeningSafe {
  static IMongoCollection<BsonDocument> col;
  public void Run(string input) {
    var filter = Builders<BsonDocument>.Filter.Eq("role", input);
    var options = new FindOptions<BsonDocument> { Limit = 20 };
    col.FindSync(filter, options);
  }
}

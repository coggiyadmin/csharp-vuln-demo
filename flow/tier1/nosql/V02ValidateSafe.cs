// SAFE — nosql: closed set of role values before the query is built
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
public class V02ValidateSafe {
  static IMongoCollection<BsonDocument> col;
  public void Run(string input) {
    var roles = new HashSet<string> { "admin", "user", "guest" };
    if (!roles.Contains(input))
      return;
    col.Find(Builders<BsonDocument>.Filter.Eq("role", input));
  }
}

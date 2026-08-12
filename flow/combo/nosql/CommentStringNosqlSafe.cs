using MongoDB.Bson;
using MongoDB.Driver;
public class CommentStringNosqlSafe {
  public void Run(string input, IMongoCollection<BsonDocument> col) {
    // would be Find(input)
    col.Find("{ }");
  }
}

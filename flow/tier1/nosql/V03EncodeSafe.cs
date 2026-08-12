using MongoDB.Bson;
using MongoDB.Driver;
public class V03EncodeSafe {
  public void Run(string input) {
    col.Find(Builders<BsonDocument>.Filter.Eq("role", input));
  }
}

// SAFE — nosql: LINQ provider translates the comparison — input stays a value
using MongoDB.Bson;
using MongoDB.Driver;
using System.Linq;
public class V05FrameworkNativeSafe {
  static IMongoCollection<BsonDocument> col;
  public void Run(string input) {
    col.AsQueryable().Where(d => d["role"] == input).ToList();
  }
}

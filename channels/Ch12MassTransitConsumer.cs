using System.Data.SqlClient;
public class Ch12MassTransitConsumer {
  public void Consume(OrderMsg msg) {
    var q = "SELECT * FROM orders WHERE id=" + msg.Id;
    var cmd = new SqlCommand(q, null);
  }
}
public class OrderMsg { public string Id { get; set; } }

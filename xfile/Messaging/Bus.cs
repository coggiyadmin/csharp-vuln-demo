namespace Demo.Xfile.Messaging;
public static class Bus {
  public static void Publish(string id) => Consumer.Handle(Producer.Payload(id));
}

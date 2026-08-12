public class BenignChatRouter {
  public string Route(string intent) => intent == "help" ? "help" : "default";
}

public class V02Safe { public void Run(string q) { if (q.All(char.IsLetterOrDigit)) { var xp = "//user[@name='" + q + "']"; } } }

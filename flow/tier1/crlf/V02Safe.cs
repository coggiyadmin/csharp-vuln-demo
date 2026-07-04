public class V02Safe { public string Run(string h) => h.All(c => char.IsLetterOrDigit(c) || c == '_') ? "X-Trace: " + h : "X-Trace: static"; }

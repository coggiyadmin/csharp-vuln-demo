using System;
public class Llm07FnSecretViaError {
  public string Run() {
    try { throw new Exception("key=" + Environment.GetEnvironmentVariable("API_KEY")); }
    catch (Exception ex) { return ex.Message; } // exfil via error
  }
}

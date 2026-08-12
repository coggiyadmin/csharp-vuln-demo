using System;
public class SafeSanitizerLogInjection {
  public void Run(string input) {
    _ = input; // sanitized / no sink
  }
}

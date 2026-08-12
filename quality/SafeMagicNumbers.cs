// SAFE — named constants.
public class SafeMagicNumbers {
  const double FreeShipThreshold = 99.99;
  const double ReducedShipThreshold = 49.99;
  const double ReducedShipCost = 4.99;
  const double StandardShipCost = 9.99;
  public double ShipCost(double total) {
    if (total < ReducedShipThreshold) return StandardShipCost;
    if (total < FreeShipThreshold) return ReducedShipCost;
    return 0;
  }
}

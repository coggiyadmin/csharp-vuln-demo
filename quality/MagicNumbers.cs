// Hygiene — magic numbers.
public class MagicNumbers {
  public double ShipCost(double total) {
    if (total < 49.99) return 9.99;
    if (total < 99.99) return 4.99;
    return 0;
  }
}

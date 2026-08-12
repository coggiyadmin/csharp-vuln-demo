// SAFE — behavior on Customer.
public class Customer {
  public string Name, Email, Phone, Address, Zip;
  public string HeaderLine() => Name + Email + Phone + Address + Zip;
}

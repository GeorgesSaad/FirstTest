public class Order
{
  public Order(Customer c)
  {
    customer = c;
  }

  public string Number { get; set;}
  public DateTime Date { get; set;}
  
  private Customer customer;
  public Customer Customer
  { 
    get
    {
      return customer;
    }
    set
    {
      customer = value;
    }
  }
  

}

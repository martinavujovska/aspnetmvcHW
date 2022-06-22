namespace BurgerApp.Models.Domain
{
    public class Order
    {
        public Order(string fullName, string address, bool isDelivered, string burgers, string location)
        {
            FullName = fullName;
            Address = address;
            IsDelivered = isDelivered;
            Burgers = burgers;
            Location = location;
        }

        public string FullName { get; set; }
        public string Address { get; set; }
        public bool IsDelivered { get; set; }
        public string Burgers { get; set; }
        public string Location { get; set; }

        public void Deliver()
        {
            if(!IsDelivered)
            {
                throw new Exception("Not delivered");
            }
            IsDelivered = false;
        }
    }
}

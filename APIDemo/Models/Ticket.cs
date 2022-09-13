namespace APIDemo.Models
{
    public class Ticket
    {
        public int ID { get; set; }
        public int Id { get; internal set; }
        public string Bookedby { get; set; }    
        public string BookerFor { get; set; }   
        public int Qty { get; set; }
        public int Price { get; set; }
        public string BookedFor { get; internal set; }
    }
}

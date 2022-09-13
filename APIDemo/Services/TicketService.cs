using APIDemo.Models;

namespace APIDemo.Services
{
    public class TicketService
    {
        static List<Ticket> Tickets { get; }
        static TicketService()
        {
            Tickets = new List<Ticket>
                {
                    new Ticket{Id=1, BookedFor="Platinum Plus",Price=5000,Qty=200 },
                    new Ticket{Id=2,BookedFor="Platinum ",Price=4000,Qty=30},
                    new Ticket{Id=3,BookedFor="Gold",Price=3000,Qty=5000},
                    new Ticket{Id =4, BookedFor="Silver",Price=2000,Qty=5000},
                    new Ticket{Id =5, BookedFor="General",Price=5000,Qty=1000}
                };
        }

        public static List<Ticket> GetAll() => Tickets;
        public static Ticket Get(int id)
        {
            Ticket ticket = Tickets.FirstOrDefault(t => t.Id == id);
            return Tickets[id];
        }
    }
}

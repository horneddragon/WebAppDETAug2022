using MVCDemo.Models;

namespace MVCDemo.Services
{
    public static class BookingService
    {
        static List<Booking> Bookings { get; }
        static int nextId = 3;
        static BookingService()
        {
            Bookings = new List<Booking>
                {
                    new Booking { Id = 1, EventTitle = "Games", EventDate=DateTime.Today, Qty=10 },
                    new Booking { Id = 2, EventTitle = "Sports", EventDate=DateTime.Today, Qty=20 }
                };
        }

        public static List<Booking> GetAll() => Bookings;

        public static Booking? Get(int id) => Bookings.FirstOrDefault(p => p.Id == id);

        public static void Add(Booking booking)
        {
            booking.Id = nextId++;
            Bookings.Add(booking);
        }

        public static void Delete(int id)
        {
            var booking = Get(id);
            if (booking is null)
                return;

            Bookings.Remove(booking);
        }

        public static void Update(Booking booking)
        {
            var index = Bookings.FindIndex(p => p.Id == booking.Id);
            if (index == -1)
                return;

            Bookings[index] = booking;
        }
    }
}

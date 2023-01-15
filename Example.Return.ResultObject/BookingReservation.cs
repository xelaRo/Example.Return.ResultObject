using FluentResults;

namespace Example.Return.ResultObject
{
    public class BookingReservation
    {
        private int[] bookings = new int[] { 1, 2, 3, 4, 5, 6 };    
        public Result<string> FindBookingById(int? bookingId)
        {
            if(bookingId is null or 0)
            {
                return Result.Fail<string>($"The booking is null or 0");
            }

            int booking = bookings.FirstOrDefault(b => b.Equals(bookingId));    

            return Result.Ok($"The booking with id: {booking} was found.");
        }
    }
}

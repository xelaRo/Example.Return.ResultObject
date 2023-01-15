// See https://aka.ms/new-console-template for more information
using Example.Return.ResultObject;

BookingReservation bookingReservation = new BookingReservation();
var result = bookingReservation.FindBookingById(7);

if (result.IsSuccess)
{
    Console.WriteLine(result.Value);
}
else
{
    Console.WriteLine(result.Reasons[0].Message);
}


Console.ReadKey();

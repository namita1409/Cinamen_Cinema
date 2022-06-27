// See https://aka.ms/new-console-template for more information
using CinamenCinema.Model;
using Npgsql;

Console.WriteLine("Welcome to Cinamen Cinema Ticket Booking System");
Console.WriteLine("available seats \n");
try
{
    var cs = "Host=localhost;Username=postgres;Password=Postgres@2526;Database=postgres";

    using var con = new NpgsqlConnection(cs);

    Booking bookingCinemaTkts = new Booking();
    bookingCinemaTkts.displayAvailableSeats(con);
    bookingCinemaTkts.BookCinemaTkts(con);
    Console.WriteLine("\n display database after the booking\n");
    bookingCinemaTkts.displayAvailableSeats(con);
}
catch (Exception e) { 
    Console.WriteLine(e.ToString());
}


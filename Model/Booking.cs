using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace CinamenCinema.Model
{
    class Booking
    {   
        public void displayAvailableSeats(NpgsqlConnection con) {

            con.Open();           
            var sql = "Select * from cinema_seats";
            using var cmd = new NpgsqlCommand(sql, con);
            using NpgsqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Console.WriteLine("{0} {1} {2} {3} {4}", rdr.GetInt32(0), rdr.GetInt32(1), rdr.GetString(2), rdr.GetString(3), rdr.GetBoolean(4));
            }
            con.Close();
        }
         public void BookCinemaTkts(NpgsqlConnection con)
            {
            var sql1 = "SELECT id from cinema_seats where isbooked=false";
            con.Open();
            using var cmd1 = new NpgsqlCommand(sql1, con);
            using NpgsqlDataReader rdr1 = cmd1.ExecuteReader();
            List<int> bookingId = new List<int>();

            while (rdr1.Read())
            {                
                bookingId.Add(rdr1.GetInt32(0));
            }  
            Console.WriteLine(bookingId.Count);

            con.Close();
            Console.WriteLine("how many tkts you want to book ?");
            int count = Convert.ToInt32(Console.ReadLine());            
            if (count <= bookingId.Count)
            {
                string str = "";
                for (int i = 0; i < count; i++)
                {
                    str += bookingId[i].ToString() + "_";
                    con.Open();
                    var sql3 = "update cinema_seats set isbooked = true where id =" + bookingId[i];
                    using var cmd2 = new NpgsqlCommand(sql3, con);
                    cmd2.ExecuteNonQuery();
                    con.Close();
                }
                Console.WriteLine("your tickets are booked booking id is " + str);
            }
            else
            {
                Console.WriteLine("sorry enough seats are not available");
            }

            con.Close();
        }

        }
    }




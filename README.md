# Cinamen_Cinema
This is demo project which allows user to book cinema tickets.
# technloiges used 
c# and PostgreSQL database for storing the seats deatails in cinema_seats table 

# high level business requirement
The Cinnamon Cinemas Movie Theatre has 15 seats, arranged in 3 rows of 5
● Rows are assigned a letter from A to C
● Seats are assigned a number from 1 to 5

# user story

As a 🍿 🎬 Cinnamon Cinemas Movie Theatre Manager
I want to allocate seats to customers
So that I can control reserved seating for the theatre

● GIVEN a customer wants to request some tickets
● WHEN they request a number of seats between 1 and 3 for a movie
● THEN the customer should be allocated the required number of seats
from the available seats on the seating plan
● AND the seats should be recorded as allocated


# database 
 Initailly all the fields in isBooked columns are set to false which  means all the seats are available for booking 
 program will ask user to enter the no of tickets he/she wants to book.  suppose user wants to book 2 tickets then it will check in the database wheather enough seats are available or not if seats are available it will book the next available tickets and update the
 'isBooked' column of the table to false
 <img width="411" alt="ciname_seats_table" src="https://user-images.githubusercontent.com/81958036/177893759-85f20a7a-b051-4a69-b88c-a796c4adb354.PNG">


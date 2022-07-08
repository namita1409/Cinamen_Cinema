# Cinamen_Cinema
This is demo project which allows user to book cinema tickets.
technloiges used - c# and PostgreSQL database for storing the seats deatails in cinema_seats table 


 <img width="411" alt="ciname_seats_table" src="https://user-images.githubusercontent.com/81958036/177893759-85f20a7a-b051-4a69-b88c-a796c4adb354.PNG">
 Initailly all the fields in isBooked columns are set to false whihc means all the seats are available for booking 
 program will ask user to enter the no of tickets he/she wants to book.  suppose user wants to book 2 tickets then it will check in the database wheather enough seats are available or not if seats are available it will book the next available tickets and update the
 'isBooked' column of the table to false

# Cinamen_Cinema
This project allows user to book cinema tickets.
I am using PostgreSQL database to store the seats deatils. 
for ex I am storing the seats deatails in cinema_seats table 

 <img width="411" alt="ciname_seats_table" src="https://user-images.githubusercontent.com/81958036/177893759-85f20a7a-b051-4a69-b88c-a796c4adb354.PNG">
 initailly all the fields in isBooked columns are set to false that means all the seats are available for booking 
 then it will ask user to enter the no of tickets user wants to book
 suppose user wants to book 2 tickets then it will check in the database wheather enough seats are available or not if seats are available it will book the tickets and update the
 'isBooked' column of the table to false

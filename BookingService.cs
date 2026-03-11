using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace KontorNord_Bookingsystem
{
    internal class BookingService
    {
        private List<Booking> bookingList;
        private int bookingIndex;


        // ========== Konstruktør ==========
        public BookingService()
        {
            bookingList = new List<Booking>();
            bookingIndex = -1;
        }
        public void CreateBooking()
        {
            // brugeren indtaster booking id, dato, starttid, sluttid, navn og mødelokale
            Console.Write("Booking ID: ");
            int bookingID = int.Parse(Console.ReadLine());

            Console.Write("Dato (dd-mm-yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Console.Write("Indtast starttid: ");
            string startTime = Console.ReadLine();

            Console.Write("Indtast sluttid: ");
            string endTime = Console.ReadLine();

            Console.Write("Indtast navn: ");
            string bookingOwner = Console.ReadLine();

            Console.Write("Indtast mødelokale (A, B eller C): ");
            char room = Console.ReadLine()[0];

            bookingList.Add(new Booking(bookingIndex + 1, date, startTime, endTime, bookingOwner, room)); // Tilføjer den nye booking til listen
            bookingIndex = bookingList.Count - 1;

            Console.WriteLine($"\nDin booking er nu oprettet! ID: {bookingID} | Dato: {date} | Tidspunkt: {startTime}-{endTime} | Navn: {bookingOwner} | Room: {room} ");

        }

        public void EditBooking()
        {
            // brugeren indtaster booking id
        }

        public void DeleteBooking()
        {
            // brugeren indtaster booking id
        }

        public void ShowBookings()
        {

        }

        // til cecilie mvh. michelle :) \ [] < > |
    }
}

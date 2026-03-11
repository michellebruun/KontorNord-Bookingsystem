using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            int bookingID = bookingIndex + 1;

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

            bookingList.Add(new Booking(bookingID, date, startTime, endTime, bookingOwner, room)); // Tilføjer den nye booking til listen
            bookingIndex = bookingList.Count - 1;

            Console.WriteLine($"\nDin booking er nu oprettet! ID: {bookingID} | Dato: {date} | Tidspunkt: {startTime}-{endTime} | Navn: {bookingOwner} | Room: {room} ");
            ShowBookings();
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
            for (int i = 0; i < bookingList.Count; i++)
            {
                Console.WriteLine($"\nID: {bookingList[i].BookingID} | Dato: {bookingList[i].Date} | Tidspunkt: {bookingList[i].StartTime}-{bookingList[i].EndTime} | Navn: {bookingList[i].BookingOwner} | Room: {bookingList[i].Room} ");
            }
        }

        // til cecilie mvh. michelle :) \ [] < > |
    }
}

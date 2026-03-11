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

			static void EditBooking(List<Booking> bookings)
			{
				Console.Write("Booking ID: ");
				int bookingID = int.Parse(Console.ReadLine());

				Booking booking = bookings.FirstOrDefault(b => b._bookingID == bookingID);

				if (booking == null)
				{
					Console.WriteLine("Booking ikke fundet.");
					return;
				}

				Console.Write("Date (yyyy-MM-dd): ");
				DateTime date = DateTime.Parse(Console.ReadLine());

				Console.Write("Start Time (hh:mm): ");
				string startTime = Console.ReadLine();

				Console.Write("End Time (hh:mm): ");
				string endTime = Console.ReadLine();

				Console.Write("Booking Owner: ");
				string bookingOwner = Console.ReadLine();

				booking.UpdateBooking(date, startTime, endTime, bookingOwner, booking._room);

				Console.WriteLine("Booking Opdateret!");
			}
		}

        public void DeleteBooking()
        // brugeren indtaster booking id
        {
            Console.Write("Indtast ID på booking du vil slette: ");
            int id = int.Parse(Console.ReadLine());

            Booking Deletebooking = null;

            foreach (var b in bookingList)
            {
                if (b._bookingID == id)
                {
                    Deletebooking = b;
                    break;
                }
            }
            if (Deletebooking != null)
            {
                bookingList.Remove(Deletebooking);
                Console.WriteLine("Booking slettet.");
            }
            else
            {
                Console.WriteLine("Booking ikke fundet.");
            }
        }

        public void ShowBookings()
        {

        }

        // til cecilie mvh. michelle :) \ [] < > |
    }
}

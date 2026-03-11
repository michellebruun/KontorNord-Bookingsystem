using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
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
 
            // skab instans af typen booking med input fra brugeren og add til listen

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

            Console.WriteLine($"\nDin booking er nu oprettet! ID: {bookingID} | Dato: {date:dd-MM-yyyy} | Tidspunkt: {startTime}-{endTime} | Navn: {bookingOwner} | Room: {room} ");

            //bookingList.OrderBy(i => i.Date); , virker ikke endnu
            //Viser resten af bookingkalenderen når metoden er færdig
            ShowBookings();
        }

        public void EditBooking()
        {
			// brugeren indtaster booking id

			static void EditBooking(List<Booking> bookings)
			{
				Console.Write("Booking ID: ");
				int bookingID = int.Parse(Console.ReadLine());

				Booking booking = bookings.FirstOrDefault(b => b.BookingID == bookingID);

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

                Console.Write("Indtast mødelokale (A, B eller C): ");
                char room = Console.ReadLine()[0];

                booking.UpdateBooking(date, startTime, endTime, bookingOwner, room);

				Console.WriteLine("Booking Opdateret!");

			}
		}

        public void DeleteBooking()
        // Brugeren indtaster booking id
        
        {
            Console.Write("Indtast ID på booking du vil slette: ");
            int id = int.Parse(Console.ReadLine());
            // Starter med null fordi vi ikke har fundet booking vi ønsker endnu
            Booking Deletebooking = null;
            // Går gennem alle bookings i listen en efter en
            foreach (var b in bookingList)
            {
                if (b.BookingID == id)
                {
                    Deletebooking = b;
                    break;
                }
            }
            // Tjekker om vi faktisk fandt en booking
            if (Deletebooking != null)
            {
                bookingList.Remove(Deletebooking);
                Console.WriteLine("Booking slettet.");
            }
            else
            {
                Console.WriteLine("Booking ikke fundet.");
            }

            //Viser resten af bookingkalenderen når metoden er færdig
            ShowBookings();
        }

        public void ShowBookings()
        {
            Console.WriteLine("======================================== Bookingkalender ========================================");
            for (int i = 0; i < bookingList.Count; i++)
            {
                Console.WriteLine($"ID: {bookingList[i].BookingID} | Dato: {bookingList[i].Date.ToString("dddd dd MMMM",CultureInfo.CreateSpecificCulture("da-DK"))} | Tidspunkt: {bookingList[i].StartTime}-{bookingList[i].EndTime} | Navn: {bookingList[i].BookingOwner} | Room: {bookingList[i].Room} ");
            }
        }

        // til cecilie mvh. michelle :) \ [] < > |
    }
}

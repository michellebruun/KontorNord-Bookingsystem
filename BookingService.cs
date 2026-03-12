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

            // brugeren indtaster booking id, dato, starttid, sluttid, navn og mødelokale
            int bookingID = bookingIndex + 1;

            Console.Write("Indtast dato (dd-mm-yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Console.Write("Indtast starttid (hh:mm): ");
            DateTime startTime = DateTime.Parse(Console.ReadLine());

            Console.Write("Indtast sluttid (hh:mm): ");
            DateTime endTime = DateTime.Parse(Console.ReadLine());

            Console.Write("Indtast navn: ");
            string bookingOwner = Console.ReadLine();

            Console.Write("Indtast mødelokale (A, B eller C): ");
            char room = Console.ReadLine()[0];

            // Fejlhåndtering af dobbeltbookinger
            if (bookingList.Count > 0)
            {
                for (int i = 0; i < bookingList.Count; i++)
                {
                    if (bookingList[i].Date == date && bookingList[i].Room == room) // Tjekker om den nye booking har samme dato og lokale som et af de andre allerede bookede møder
                    {
                        if (bookingList[i].StartTime < endTime && bookingList[i].EndTime > startTime) // Tjekker om den nye booking starter inden et af de andre møder ender, og om den ender før et af de andre møder starter
                        {
                            Console.WriteLine("Fejl: Lokalet er allerede booket på det ønskede tidspunkt - Din booking kunne ikke oprettes, prøv igen:");
                            return;
                        }
                    }
                }
            }

            bookingList.Add(new Booking(bookingID, date, startTime, endTime, bookingOwner, room)); // Tilføjer den nye booking til listen
            bookingIndex = bookingList.Count - 1;

            Console.WriteLine($"\nDin booking er nu oprettet! ID: {bookingID} | Dato: {date:dd-MM-yyyy} | Tidspunkt: {startTime:HH:mm} - {endTime:HH:mm} | Navn: {bookingOwner} | Room: {room} ");

            // Viser resten af bookingkalenderen når metoden er færdig
            Console.Write('\n');
            ShowBookings();
        }

        public void EditBooking()
        {
			// brugeren indtaster booking id

			{
				Console.Write("Booking ID: ");
				int bookingID = int.Parse(Console.ReadLine());

                Booking Editbooking = null;

                foreach (var b in bookingList)
                {
                    if (b.BookingID == bookingID)
                    {
                        Editbooking = b;
                        break;
                    }
                }
                
				if (Editbooking == null)
				{
					Console.WriteLine("Booking ikke fundet.");
					return;
				}

				Console.Write("Indtast dato (dd-mm-yyyy): ");
				DateTime date = DateTime.Parse(Console.ReadLine());

				Console.Write("Indtast starttid (hh:mm): ");
				DateTime startTime = DateTime.Parse(Console.ReadLine());

                Console.Write("Indtast sluttid (hh:mm): ");
				DateTime endTime = DateTime.Parse(Console.ReadLine());

                Console.Write("Indtast navn: ");
				string bookingOwner = Console.ReadLine();

                Console.Write("Indtast mødelokale (A, B eller C): ");
                char room = Console.ReadLine()[0];

                Editbooking.UpdateBooking(date, startTime, endTime, bookingOwner, room);

                Console.WriteLine($"\nDin booking er nu opdateret!");

                // Viser resten af bookingkalenderen når metoden er færdig
                Console.Write('\n');
                ShowBookings();
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

            // Viser resten af bookingkalenderen når metoden er færdig
            Console.Write('\n');
            ShowBookings();
        }

        public void ShowBookings()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("======================================== Bookingkalender ========================================");
            Console.ResetColor();
            for (int i = 0; i < bookingList.Count; i++)
            {
                Console.WriteLine($"ID: {bookingList[i].BookingID} | Dato: {bookingList[i].Date.ToString("dddd dd MMMM yyyy",CultureInfo.CreateSpecificCulture("da-DK"))} | Tidspunkt: {bookingList[i].StartTime:HH:mm} - {bookingList[i].EndTime:HH:mm} | Navn: {bookingList[i].BookingOwner} | Room: {bookingList[i].Room} ");
            }
        }
    }
}

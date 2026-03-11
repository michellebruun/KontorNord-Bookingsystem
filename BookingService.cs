using System;
using System.Collections.Generic;
using System.Text;

namespace KontorNord_Bookingsystem
{
    internal class BookingService
    {
        private List<Booking> bookingList;
        private int bookingIndex;


        //Konstruktør
        public BookingService()
        {
            bookingList = new List<Booking>();
            bookingIndex = -1;
        }
        public void CreateBooking()
        {
            Console.Write("Booking ID: ");
            int bookingID = int.Parse(Console.ReadLine());

            Console.Write("Date (yyyy-mm-dd): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            // skab instans af typen booking med input fra brugeren og add til listen
            bookingIndex = bookingList.Count - 1;
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
        {
            // brugeren indtaster booking id
        }

        public void ShowBookings()
        {

        }
    }
}

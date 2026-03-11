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

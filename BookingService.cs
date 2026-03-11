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
            // skab instans af typen booking med input fra brugeren og add til listen
            bookingIndex = bookingList.Count - 1;
        }

        public void EditBooking()
        {
            // brugeren indtaster booking id
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
    }
}

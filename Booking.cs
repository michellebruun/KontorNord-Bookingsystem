using System;
using System.Collections.Generic;
using System.Text;

namespace KontorNord_Bookingsystem
{
    internal class Booking
    {
        private int _bookingID;
        private DateTime _date;
        private DateTime _startTime;
        private DateTime _endTime;
        private string _bookingOwner;
        private char _room;


        public int BookingID
        {
            get { return _bookingID; }
            set { _bookingID = value; }
        }
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        public DateTime StartTime
        {
            get { return _startTime; }
            set { _startTime = value; }
        }
        public DateTime EndTime
        {
            get { return _endTime; }
            set { _endTime = value; }
        }
        public string BookingOwner
        {
            get { return _bookingOwner; }
            set { _bookingOwner = value; }
        }
        public char Room
        {
            get { return _room; } 
            set { _room = value; }
        }

        //Konstruktør
        public Booking(int bookingID, DateTime date, DateTime startTime, DateTime endTime, string bookingOwner, char room)
        {
            _bookingID = bookingID;
            _date = date;
            _startTime = startTime;
            _endTime = endTime;
            _bookingOwner = bookingOwner;
            _room = room;
        }

        public void UpdateBooking(DateTime date, DateTime startTime, DateTime endTime, string bookingOwner, char room)
        {
            _date = date;
            _startTime = startTime;
            _endTime = endTime;
            _bookingOwner = bookingOwner;
            _room = room;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace KontorNord_Bookingsystem
{
    internal class Booking
    {
        public int _bookingID;
        public DateTime _date;
        public string _startTime;
        public string _endTime;
        public string _bookingOwner;
        public MeetingRoom _room;

        //Konstruktør
        public Booking(int bookingID, DateTime date, string startTime, string endTime, string bookingOwner, MeetingRoom room)
        {
            _bookingID = bookingID;
            _date = date;
            _startTime = startTime;
            _endTime = endTime;
            _bookingOwner = bookingOwner;
            _room = room;
        }

    }
}

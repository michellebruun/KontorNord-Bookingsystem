using System;
using System.Collections.Generic;
using System.Text;

namespace KontorNord_Bookingsystem
{
    internal class Booking
    {
        private int bookingId;
        private DateTime date;
        private string startTime;
        private string endTime;
        private string bookedBy;
        private MeetingRoom room;

        public Booking(int bookingId, DateTime date, string startTime, string endTime, string bookedBy, MeetingRoom room)
        {
            this.bookingId = bookingId;
            this.date = date;
            this.startTime = startTime;
            this.endTime = endTime;
            this.bookedBy = bookedBy;
            this.MeetingRoom = room;
        }

        public void UpdateBooking(DateTime date, string startTime, string endTime, string bookedBy, MeetingRoom room)
        {
            this.date = date;
            this.startTime = startTime;
            this.endTime = endTime;
            this.bookedBy = bookedBy;
            this.MeetingRoom = room;
        }
    }
}

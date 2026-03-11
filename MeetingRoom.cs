using System;
using System.Collections.Generic;
using System.Text;

namespace KontorNord_Bookingsystem
{
    internal class MeetingRoom
    {
        public int _roomID;
        public string _name;

        //Konstruktør
        public MeetingRoom(int roomID, string name)
        {
            _roomID = roomID;
            _name = name;
        }
    }
}

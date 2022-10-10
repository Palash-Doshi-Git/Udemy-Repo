using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Udemy
{
    abstract class Ticket
    {
        private int seat;
        private string row;
        private string eventDateTime;
        private string eventName;
        private string eventType;
        private string eventLocation;
        private double ticketCost;


        public Ticket(int seatNum, string rowID, string dateTime1, string nameEvent, string type, string location, double cost)
        {
            eventType = type;
            eventName = nameEvent;
            eventLocation = location;
            eventDateTime = dateTime1;
            seat = seatNum;
            row = rowID;
            ticketCost = cost;

        }



        public string EventName
        {
            get { return eventName; }
            set { eventName = value; }
        }

        public int Seat
        {
            get { return seat; }
            set { seat = value; }
        }

        public string Row
        {
            get { return row; }
            set { row = value; }
        }

        public string EventDateTime
        {
            get { return eventDateTime; }
            set { eventDateTime = value; }
        }

        public string GetEventType()
        { return eventType; }

        public void SetEventType(string value)
        {
            eventType = value;
        }

        public double TicketCost
        {
            get { return ticketCost; }
            set
            {
                ticketCost = value;
            }
        }
        public string EventType
        {
            get { return eventType; }
            set
            {
                eventType = value;
            }
        }

        public string Eventlocation
        {
            get { return eventLocation; }
            set
            {
                eventLocation = value;
            }
        }

        public override string ToString()
        {
            return eventType.ToUpper() + ":\t" + eventName +
                "\n\tWhere:\t" + eventLocation +
                "\n\tWhen:\t" + eventDateTime +
                "\n\tCost:\t" + eventDateTime +
                "\n\tCost:\t" + ticketCost.ToString("C")
                + "\n\tRow - Seat: " + row + " - " + seat;
        }
    }

}

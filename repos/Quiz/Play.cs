using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class Play:Ticket
    {
        public bool refreshmentsServed;
        private int numberOfActors;
        private string playSpecficInfo;

        public Play(int seatNum, string rowId, string dateTime, string nameEvent,string type, string location , bool refreshments,int numOfActors , string playInfo, double cost)
            :base(seatNum,rowId,dateTime,nameEvent,type,location,cost)
        {
            refreshmentsServed = refreshments;
            playSpecficInfo= playInfo;
            numberOfActors = numOfActors;
        }

        public bool RefreshmentsServed
        {
            get { return refreshmentsServed; }
            set { refreshmentsServed = value; }
        }

        public string PlaySpecficInfo
        {
            get { return playSpecficInfo; }
            set { playSpecficInfo = value; }
        }

        public int NumberOfActors
        {
            get { return numberOfActors; }
            set { numberOfActors = value; }
        }

        public override string ToString()
        {
            return base.ToString()+ "\nNumber of Actors"+ numberOfActors;
        }









    }
}

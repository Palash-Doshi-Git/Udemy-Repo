using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Udemy
{
    class Musical : Ticket
    {
        private string performerName;
        private bool memoriabilityOnSale;
        private bool backStageOffered;
        private bool signsAutographAvailable;

        public Musical(int seatNum, string rowId, string nameEvent, string type, string location, string performer, string eventDateTime, bool memoriability,
            bool backStage, bool signsAutograph, double cost)
            : base(seatNum, rowId, eventDateTime, nameEvent, type, location, cost)
        {
            performerName = performer;
            memoriabilityOnSale = memoriability;
            backStageOffered = backStage;
            signsAutographAvailable = signsAutograph;
        }
        public string Performername
        {
            get { return performerName; }
            set { performerName = value; }
        }

        public bool MemoriabilityOnSale {
            get => memoriabilityOnSale;
            set => memoriabilityOnSale = value;
        }

        public bool BackStageOffered
        {
            get { return backStageOffered; }
            set { backStageOffered = value; }
        }

        public bool SignsAutographAvailable
        {
            get { return signsAutographAvailable; }
            set { signsAutographAvailable = value; }

        }

        public override string ToString()
        {
            return base.ToString()+"\nPerformers: "+performerName;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    public enum EventType { Golf = 1, Bowling, AmusementPark, Concert, }
    class Event
    {
        public EventType TypeOfEvent { get; set; }
        public int NumberOfPeople { get; set; }
        public DateTime DateOfEvent { get; set; }
        public decimal CostPerPerson { get; set; }
        public decimal CostOfEvent { get; set; }
        public Event EventType { get; internal set; }

        public Event(EventType typeOfEvent, int numberOfPeople, DateTime dateOfEvent, decimal costPerPerson, decimal costOfEvent)
        {
            TypeOfEvent = typeOfEvent;
            NumberOfPeople = numberOfPeople;
            DateOfEvent = dateOfEvent;
            CostPerPerson = costPerPerson;
            CostOfEvent = numberOfPeople * costPerPerson;
        }
        public Event()
        {
        }

    }
}

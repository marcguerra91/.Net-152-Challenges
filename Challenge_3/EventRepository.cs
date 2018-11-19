using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    class EventRepository
    {
        List<Event> _listOfClaim = new List<Event>();
        public void AddContentToList(Event content)
        {
            _listOfClaim.Add(content);
        }
        public List<Event> GetEventsList()
        {
            return _listOfClaim;
        }
        public decimal TotalCostOfEvents()
        {
            decimal Total = 0m;
            foreach (Event events in _listOfClaim)
            {
                Total += events.CostOfEvent;
            }
            return Total;
        }

    }
}

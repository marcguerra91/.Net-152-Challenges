using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    class ProgramUI
    {   
        EventRepository _eventRepository = new EventRepository();
        List<Event> eventList;
        private decimal Total;

        public void Run()
        {   
            Event firstEvent = new Event(EventType.Golf, 5, new DateTime(2018,06,26), 25.00m, 125.00m);
            Event secondEvent = new Event(EventType.Bowling, 8, new DateTime(2018, 12, 01), 15.00m, 120.00m);
            Event thirdEvent = new Event(EventType.AmusementPark, 4, new DateTime(2018, 10, 16), 50.00m, 200.00m);
            Event fourthEvent = new Event(EventType.Concert, 5, new DateTime(2018, 05, 28), 100.00m, 500.00m);
            _eventRepository.AddContentToList(firstEvent);
            _eventRepository.AddContentToList(secondEvent);
            _eventRepository.AddContentToList(thirdEvent);
            _eventRepository.AddContentToList(fourthEvent);

            eventList = _eventRepository.GetEventsList();
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Komodo Outing Information");
                Console.WriteLine("Select an option:" +
                    "\n1. View Events" +
                    "\n2. Create Event" +
                    "\n3. View total cost of events" +
                    "\n4. Exit");

                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1: //view events
                        ViewEvents();
                        break;
                    case 2: //create an event
                        CreateEvent();
                        break;
                    case 3: //total cost of events
                        Console.Clear();
                        TotalCostByEvent();
                        Console.WriteLine($"\nTotal cost of  all events {_eventRepository.TotalCostOfEvents()}\n");
                        break;
                    case 4://exit
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Response.\n Please Select 1-3");
                        Console.ReadLine();
                        break;
                }
            }
        }
        private void ViewEvents()
        {
            Console.Clear();
            List<Event> eventList = _eventRepository.GetEventsList();
            
            foreach(Event content in eventList)
            {
                Console.WriteLine($"Event type:\t Attendees:\t\t Date of event:\t\t Price per person:\t\t Total cost of event:\n {content.TypeOfEvent}\t\t {content.NumberOfPeople}\t\t {content.DateOfEvent}\t\t {content.CostPerPerson}\t\t\t\t {content.CostOfEvent}\t \n");
            }
        }
        private void CreateEvent()
        {
            Event newEvent = new Event();
            Console.WriteLine("\nPlease select an Event type: Golf, Bowling, Amusement Park, Concert\n");
            string input = Console.ReadLine().ToLower();
            switch (input)
            {
                case "golf":
                    newEvent.TypeOfEvent = EventType.Golf;
                    break;
                case "bowling":
                    newEvent.TypeOfEvent = EventType.Bowling;
                    break;
                case "amusementPark":
                    newEvent.TypeOfEvent = EventType.AmusementPark;
                    break;
                case "concert":
                    newEvent.TypeOfEvent = EventType.Concert;
                    break;
                default:
                    Console.WriteLine("invalid response");
                    Console.ReadLine();
                    break;
            }
            Console.Clear();
            Console.WriteLine("Enter many people attended this event?");
            newEvent.NumberOfPeople = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the date of the event in the following format: YYYY/MM/DD");
            newEvent.DateOfEvent = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter the price per person attending the event");
            newEvent.CostPerPerson = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the total cost for the event");
            newEvent.CostOfEvent = newEvent.NumberOfPeople * newEvent.CostPerPerson;

            _eventRepository.AddContentToList(newEvent);
        }
        private void TotalCostByEvent()
        {
            Console.Clear();
            Console.WriteLine("Cost for each event");
            Console.WriteLine();
            foreach (Event content in _eventRepository.GetEventsList())
            {
                Console.WriteLine($"{content.TypeOfEvent} - ${content.CostOfEvent}");
                Console.WriteLine();
            }
        }
        
        
    }
}

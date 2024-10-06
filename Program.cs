using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {

       
            List<Event>eventList=new List<Event>(); 
            // יצירת מספר אירועים
            Event event1 = new Event( "יום הולדת", new DateTime(2023, 12, 25));
            Event event2 = new Event("פגישה חשובה", new DateTime(2024, 11, 10));
            Event event3 = new Event(" מסיבה", new DateTime(2020, 01, 5));
            Event event4 = new Event(" הופעה", new DateTime(2021, 01, 14));
            Event event5 = new Event(" שיעור בית ", new DateTime(2015, 04, 01));
            eventList.Add(event1);
            eventList.Add(event2);
            eventList.Add(event3);  
            eventList.Add(event4);
            event1.getAllEvents(eventList);
            //event1.updateEvent(0,eventList);
            event1.getAllEvents(eventList);
            Console.WriteLine("-------------");
            event1.getAllEvents(eventList);

            event1.addEvaent(event5, eventList);
            Console.WriteLine("-------------");
            event1.getAllEvents(eventList);






        }
    }
}

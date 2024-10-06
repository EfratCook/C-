using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3
{
    internal class Event
    {
 
        public int Id;
        public string Title;
        public DateTime start;

        public Event( string title, DateTime start2)
        {
            this.Id = Id++;    
            this.Title = title;
            this.start = start2;

        }
        public void setTitle(string title)
        {
            Title = title;
        }

        public void getAllEvents(List<Event> events)
        {
            foreach (Event e in events)
            {
                Console.WriteLine($"id: {e.Id}, Title: {e.Title}, start: {e.start}");
            }
        }
        public void addEvaent(Event e, List<Event> events)
        {
          events.Add(e);    

        }
        public void updateEvent(int id,List<Event> events)
        {
            foreach(Event e in events)
            {
                if(e.Id == id)
                {
                    e.setTitle("Bar-Mitzva");
                }
            }

        }
        public void deleteEvent(List<Event> events,int id)
        {
            foreach (Event e in events)
            {
                if (e.Id == id)
                {
                    events.Remove(e);
                   
                }
            }

        }
    }
}

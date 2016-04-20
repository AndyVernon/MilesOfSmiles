namespace MilesOfSmiles.Models
{
    using System.Collections.Generic;

    public class EventViewModel
    {
        public List<EventModel> AllEvents { get; set; }
        public List<EventModel> FutureEvents
        {
            get 
            {
                var events = new List<EventModel>();
                foreach (var item in AllEvents)
                {
                    if (item.InFuture)
                    {
                        events.Add(item);
                    }
                }
                return events;
            }
        }
    }
}
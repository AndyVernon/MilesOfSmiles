namespace MilesOfSmiles.Models
{
    using System;
    public class EventModel
    {
        public string EventTitle { get; set; }
        public string EventDetails { get; set; }
        public DateTime? EventDate { get; set; }
        public string FacebookLink { get; set; }
        public bool InFuture 
        { 
            get 
            { 
                return DateTime.Today < EventDate || EventDate == null; 
            } 
        }
    }
}
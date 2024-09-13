﻿namespace PottabattinaTicketSales.Models
{
    public class ListViewModel
    {
        /*
         * Created by Triveni Pottabattina
         * 4444444444444444444444444444444
         */
        public IEnumerable<Event> Events { get; }
        public List<Category> Categories { get; }
        public string? SelectedCategory { get; }
        public ListViewModel(IEnumerable<Event> events, List<Category> categories, string selectedCategory)
        {
            Events = events;
            Categories = categories;
            SelectedCategory = selectedCategory;
        }//ctor

    }//ListViewModel class
}//namepsace PottabattinaTicketSales.Models

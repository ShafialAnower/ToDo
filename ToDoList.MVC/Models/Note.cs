﻿namespace ToDoList.MVC.Models
{
    public class Note
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool SoftDelete { get; set; }

    }
}

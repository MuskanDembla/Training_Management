﻿namespace Training_Management.Models
{
    public class BatchViewModel
    {


        public int Id { get; set; }
        public string BatchName { get; set; }
        public string Trainer { get; set; }
        public DateTime? StartDate { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
    }
}

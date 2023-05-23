﻿namespace Training_Management.Models
{
    public class Batch
    {
        public int BatchId { get; set; }

        public string BatchName { get; set; }

        public DateTime StartDate { get; set; }

        public string Trainer { get; set; }

        public Course Course { get; set; }

        public int CourseId { get; set; }


    }
}

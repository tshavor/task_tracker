using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class task
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public Status Taskstatus { get; set; }

        public DateTime CompletedOn { get; set; }

    }

    public enum Status
    {
        ToDo, InProgress, Complete
    }
}



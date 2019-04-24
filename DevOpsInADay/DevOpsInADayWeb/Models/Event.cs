using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevOpsInADayWeb.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Date { get; set; }
        public int Registrants { get; set; }
    }
}

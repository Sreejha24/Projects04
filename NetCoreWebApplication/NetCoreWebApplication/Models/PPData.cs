using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreWebApplication.Models
{
    [Table("PP_Data")]
    public class PPData
    {
        [Key]
        public string Person_Id { get; set; }
        public string Name { get; set; }
        public DateTime Person_Date { get; set; }
        public string Mobile_Number { get; set; }
        public string Year { get; set; }
        public string Qualification { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Auto_Id { get; set; }
        public string Location { get; set; }
        public string Gender { get; set; }
    }
}
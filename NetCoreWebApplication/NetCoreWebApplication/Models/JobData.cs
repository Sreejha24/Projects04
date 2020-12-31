using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreWebApplication.Models
{
    [Table("Job_Data")]
    public class JobData
    {
      
        public string Job_Id { get; set; }
        public string Role { get; set; }
        public string Specification { get; set; }
        public string Qualification { get; set; }
        public string Passyear { get; set; }
        public string Skills { get; set; }
        [DataType(DataType.Currency)]
        public decimal Expected_Salary { get; set; }
       
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Auto_Id { get; set; }
    }
} 
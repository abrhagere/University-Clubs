using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Criminal.Models
{
    public class Crime
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CrimId { get; set; }
        public string CrimeName { get; set; }
        [DataType(DataType.Date)]
        public string CrimeDate { get; set; }
    }
}
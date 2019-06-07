using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MU_Clubs.Models
{
    public class Comment
    {
        [Key]
        public string Id { get; set; }
        [DataType(DataType.MultilineText)]
        public string Coment{ get; set; }
    }
}
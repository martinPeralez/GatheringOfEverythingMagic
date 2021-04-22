using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MTGWebsite.Models
{
    [Table("Set")]
    public class Set
    {
        public int      Id                  { get; set; }
        public string   Name                { get; set; }
        public int      CardCount           { get; set; }
        public bool     InStandardRotation  { get; set; }
    }
}

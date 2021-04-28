using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MTGWebsite.Models
{
    [Table("Card")]
    public class Card
    {
        public int      Id              { get; set; }
        public string   Name            { get; set; }
        public string   ManaCost        { get; set; }
        public int      ConvertedMana   { get; set; }
        public string   Type            { get; set; }
        public string   CardText        { get; set; }
        public string   FlavorText      { get; set; }
        public string   Expansion       { get; set; }
        public string   Rarity          { get; set; }
        public int      CardNumber      { get; set; }
        public string   Image           { get; set; }
        public int      ?Power           { get; set; }
        public int      ?Toughness       { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuperHeroCreator.Models
{
    public class Superheros
    {
        [Key]
        public int Id;
        public string Name;
        public string AlterEgo;
        public string PrimaryAbility;
        public string SecondaryAbility;
        public string Catchphrase;


        public Superheros()
        {
            
        }
    }
}
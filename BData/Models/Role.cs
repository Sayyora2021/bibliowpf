﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace BData.Models
{
    public partial class Role
    {
        public Role()
        {
            Personnes = new HashSet<Personne>();
        }

        public int id { get; set; }
        public string nom { get; set; }

        public virtual ICollection<Personne> Personnes { get; set; }
    }
}
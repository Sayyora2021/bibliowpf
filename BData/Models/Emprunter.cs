﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace BData.Models
{
    public partial class Emprunter
    {
        public int id { get; set; }
        public int? idLivre { get; set; }
        public int? idLecteur { get; set; }
        public DateTime? dateEmprunt { get; set; }
        public DateTime? dateRetour { get; set; }

        public virtual Personne idLecteurNavigation { get; set; }
        public virtual Livre idLivreNavigation { get; set; }
    }
}
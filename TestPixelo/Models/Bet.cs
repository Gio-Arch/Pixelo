//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestPixelo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Bet
    {
        public int ID { get; set; }
        [Required]
        public string MatchDescription { get; set; }
        public decimal RateOne { get; set; }
        public decimal RateDraw { get; set; }
        public decimal RateTwo { get; set; }
    }
}

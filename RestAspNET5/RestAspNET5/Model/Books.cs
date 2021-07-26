﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using RestAspNET5.Model.Base;

namespace RestAspNET5.Model
{
    [Table("books")]
    public class Books : BaseEntity
    {
        [Column("author")]
        public string Author { get; set; }
        
        [Column("launch_date")]
        public DateTime LaunchDate { get; set; }
        
        [Column("price")]
        public double Price { get; set; }
        
        [Column("title")]
        public string Title { get; set; }
    }
}
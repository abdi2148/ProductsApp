﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProductsApp.Core.Entities
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public string Color { get; set; }

        public string Type { get; set; }

        public DateTime CreatedDate { get; set; }

        [Required]
        public bool IsComplete { get; set; }

    }
}
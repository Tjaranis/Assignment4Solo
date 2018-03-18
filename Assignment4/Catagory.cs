﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Assignment4
{
    public class Category
    {
        //[Column("categoryid")]
        public int Id { get; set; }
        [StringLength(15)]
        public string Name { get; set; }
        public string Description { get; set; }

        public Category() { };

        public Category(string name, string Description)
        {
            this.Name = name;
            this.Description = Description;
        }
    }
}

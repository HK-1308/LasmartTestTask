using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LasmartTestTask.Data.Models
{
    public class Point
    {
        [Key]
        public int Id { get; set; }

        public decimal PositionX { get; set; }

        public decimal PositionY { get; set; }

        public decimal Radius { get; set; }

        public string Color { get; set; }

        public virtual List<Comment> Comments { get; set; }
    }
}

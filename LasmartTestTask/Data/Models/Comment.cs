using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LasmartTestTask.Data.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }

        public string Color { get; set; }

        public int PointId { get; set; }

       // public virtual Point Point { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Playground.Data
{
    [Table("Drawing")]
    public class Drawing
    {
        [Key]
        public int Id { get; set; }

        public string DrawingJson { get; set; }
    }
}

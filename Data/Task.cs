using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Playground.Data
{
    public class Task
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        public int Order { get; set; }
        public bool Complete { get; set; }
    }
}

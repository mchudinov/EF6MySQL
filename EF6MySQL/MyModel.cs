using System;
using System.ComponentModel.DataAnnotations;

namespace EF6MySQL
{
    public class MyModel
    {
        public MyModel ()
        {
            Id = Guid.NewGuid();
            DateTime = DateTime.Now;
        }

        [Key]
        public Guid Id {get; set;}

        [StringLength(300)]
        public string Value {get; set;}

        [Required]
        public DateTime DateTime { get; set; }
    }
}


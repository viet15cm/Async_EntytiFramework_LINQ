using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Async_EntytiFramework.Model
{
    public class Grader
    {
        [Key]
        public Guid Id { get; set; }
        [StringLength(30)]
        public string Name { get; set; }
        [StringLength(30)]
        public string Amount { get; set; }

        public virtual ICollection<Student> Students { get; set; }

    }
}

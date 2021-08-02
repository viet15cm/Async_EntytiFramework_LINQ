using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Async_EntytiFramework.Model
{
    public class Student
    {
        [Key]
        public Guid Id { get; set; }
        [StringLength(30)]
        public string Name { get; set; }
        public int? Age { get; set; }
        public bool? Gender { get; set; }
        public Guid? GraderId { get; set; }
        public DateTime? Birthday { get; set; }

        public virtual Grader Grader { get; set; }



    }
}

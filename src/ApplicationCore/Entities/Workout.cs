using System;
using System.Collections;
using System.Collections.Generic;

namespace ApplicationCore.Entities
{
    public class Workout : BaseEntity
    {
        public DateTime Date { get; set; }
        public ICollection<Set> Sets { get; set; }
    }
}
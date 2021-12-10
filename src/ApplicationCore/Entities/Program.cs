using System;
using System.Collections.Generic;

namespace ApplicationCore.Entities
{
    public class Program : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Workout> Workouts { get; set; }

        public virtual Organization Organization { get; set; }
    }
}
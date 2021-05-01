﻿using System.Collections.Generic;

namespace EFCodeFirst.Entities
{
    public class Title
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Employee> Employees { get; set; } = new List<Employee>();
    }
}

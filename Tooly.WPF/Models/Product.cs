using System;
using System.Collections.Generic;
using System.Text;

namespace Tooly.WPF.Models
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Category}";
        }
    }
}

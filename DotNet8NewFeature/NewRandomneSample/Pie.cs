using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRandomneSample
{
    public class Pie
    {
        public int Id { get; }
        public string Name { get; }
        public decimal Price { get; }

        public Pie(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

       

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(Price)}: {Price}";
        }
    }

}

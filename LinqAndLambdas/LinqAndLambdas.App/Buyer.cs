using System;
using System.Collections.Generic;
using System.Text;

namespace LinqAndLambdas.App
{
    public class Buyer
    {
        public Buyer(int id, string name, int district, int age)
        {
            Id = id;
            Name = name;
            District = district;
            Age = age;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int District { get; set; }
        public int Age { get; set; }
    }
}

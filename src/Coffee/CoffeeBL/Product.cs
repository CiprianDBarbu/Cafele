using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeBL
{
    public enum validation_result
    {
        succes = 0,
        pricing_incorrect = 1,
        name_inccorect = 2
    }
    public abstract class Product
    {
        public string name { get; set; }
        public float price { get; set; }

        public validation_result IsValid()
        {
            if (price < 0) return validation_result.pricing_incorrect;
            if (string.IsNullOrWhiteSpace(name)) return validation_result.name_inccorect;
            return validation_result.succes;
        }

    }
}

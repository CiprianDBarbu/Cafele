using CoffeeBL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Menu
{
    public class CoffeeMenu
    {
        public CoffeeMenu()
        {
            CoffeeMenuList = new List<Coffee>();

        }
        public List<Coffee> CoffeeMenuList { get; set; }

        public void loadfromfile() {

           string[] lines = File.ReadAllLines("ListCoffee.txt");
            for (int i = 1; i < lines.Length; i++)
            {
                var line = lines[i];
                var split = line.Split(',');
                Coffee aux = new Coffee();
                aux.name = split[0];
                aux.origin_country = split[1];
                aux.price = float.Parse(split[2]);
                aux.flavour = (eflavour_coffee)int.Parse(split[3]);
                CoffeeMenuList.Add(aux);

            }

        }

        public Coffee GiveCoffeeAfterName(string name)
        {

            return CoffeeMenuList.FirstOrDefault(it => it.name == name);
            //for (int i = 0; i < CoffeeMenuList.Count; i++)
            //{
            //    var curent = CoffeeMenuList[i];

            //    if (name == curent.name)
            //        return curent;
            //}

            //return null;
        }

        public bool ExistCoffee(string name)
        {

            return GiveCoffeeAfterName(name) != null;
            //return CoffeeMenuList.Exists(it => it.name == name);

            //return (CoffeeMenuList.Where(it => it.name == name).Count() == 1);


            //bool find = false;
            //for (int i = 0; i < CoffeeMenuList.Count; i++)
            //{
            //    var curent = CoffeeMenuList[i];
            //    if (name == curent.name)
            //    {
            //        find = true;
            //        break;
            //    }
            //}
            //return find;
        }

    }
}

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
            //Linq

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

              //Afisare Cafea in ordinea citirii
        private void ShowCoffee()
        {
            for(int i = 0; i < CoffeeMenuList.Count; i++)
            {
                var curent = CoffeeMenuList[i];
                Console.WriteLine($"{curent.name} {curent.price}");
            }
        }
       
        public int CompareCoffeeName(Coffee A, Coffee B)
        {
            return A.name.CompareTo(B.name);
        }

        public void ShowCoffeeInOrder()
        {
           // CoffeeMenuList.Sort(CompareCoffeeName);
            CoffeeMenuList.Sort((Coffee A, Coffee B) => A.name.CompareTo(B.name));
            //CoffeeMenuList = CoffeeMenuList.OrderBy(q => q).ToList();  // Am gasit si varinta aceasta insa nu stiu daca merge(sau care)
            this.ShowCoffee(); //nu stiu daca exista pointerul this
        }

    }
}

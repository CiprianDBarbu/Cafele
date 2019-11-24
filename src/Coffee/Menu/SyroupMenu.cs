using CoffeeBL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Menu
{
    public class SyroupMenu
    {
        public SyroupMenu()
        {
            SyroupMenuList = new List<Syroup>();
        }
        public List<Syroup> SyroupMenuList { get; set; }
        public void loadfromfile()
        {
            string[] lines = File.ReadAllLines("ListSyroup.txt");
            for (int i = 1; i < lines.Length; i++)
            {
                var line = lines[i];
                var split = line.Split(',');
                Syroup aux = new Syroup();
                aux.name = split[0];
                aux.flavour = (eflavour_syroup)int.Parse(split[1]);
                aux.price = float.Parse(split[2]);
                SyroupMenuList.Add(aux);
            }
        }
        public Syroup GiveSyroupAfterName(string name)
        {
            for (int i = 0; i < SyroupMenuList.Count; i++)
            {
                var curent = SyroupMenuList[i];

                    if (name == curent.name)
                        return curent;
            }
            return null;
        }

        public bool ExistSyroup(string name)
        {
            bool find = false;
            for (int i = 0; i < SyroupMenuList.Count; i++)
            {
                var curent = SyroupMenuList[i];
                if (name == curent.name)
                {
                    find = true;
                    break;
                }
            }
            return find;
        }
        private void ShowSyroup()
        {
            for (int i = 0; i < SyroupMenuList.Count; i++)
            {
                var curent = SyroupMenuList[i];
                Console.WriteLine($"{curent.name} {curent.price}");
            }
        }

        public int CompareSyroupName(Coffee A, Coffee B)
        {
            return A.name.CompareTo(B.name);
        }

        public void ShowSyroupInOrder()
        {
            SyroupMenuList.Sort((Syroup A, Syroup B) => A.name.CompareTo(B.name));
            this.ShowSyroup();
        }
    }
}

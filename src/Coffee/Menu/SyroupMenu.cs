using CoffeeBL;
using System;
using System.Collections.Generic;
using System.Globalization;
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

        public void loadfromfile(string path)
        {
            var culture = CultureInfo.CreateSpecificCulture("en-US");
            string[] lines = File.ReadAllLines(path);
            for (int i = 1; i < lines.Length; i++)
            {
                var line = lines[i];
                var split = line.Split(',');
                Syroup aux = new Syroup();
                aux.name = split[0];
                aux.flavour = (eflavour_syroup)float.Parse(split[1]);
                aux.price = float.Parse(split[2],culture);
                SyroupMenuList.Add(aux);
            }
        }

        public void loadfromfile()
        {
            loadfromfile("ListSyroup.txt");
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
        public void ShowSyroup()
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

        public void InOrder()
        {
            SyroupMenuList.Sort((Syroup A, Syroup B) => A.name.CompareTo(B.name));
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CoffeeBL;
using Menu;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;


namespace CoffeeWeb.Controllers
{
    public enum search_type
    {
        coffee = 0,
        syroup = 1
    }

    [Route("api/[controller]/{action}")]
    [ApiController]
    public class CoffeeController : ControllerBase
    {

        private string FindFile(string path, search_type what)
        {
            //Directory.GetFiles(path, "ListCoffee.txt", SearchOption.AllDirectories);
            string where = null;
            if (what == search_type.coffee)
            {
                where = "ListCoffee.txt";
            }
            else
            {
                if (what == search_type.syroup)
                {
                    where = "ListSyroup.txt";
                }
            }

            var files = Directory.GetFiles(path, where);


            if (files.Length == 1)
            {
                return files[0];
            }

            var dirs = Directory.GetDirectories(path);
            for (int i = 0; i < dirs.Length; i++)
            {
               var file = FindFile(dirs[i], what);
                if (file != null)
                    return file;
            }

            return null;

        }

       
        [HttpGet]
        public Coffee[] AllCofees()
        {
            
            Program.NrRequests++;
            var folder = Directory.GetCurrentDirectory();
            var fileCoffee = FindFile(folder, search_type.coffee);
            CoffeeMenu cm = new CoffeeMenu();
            cm.loadfromfile(fileCoffee);
            cm.InOrder();
            return cm.CoffeeMenuList.ToArray();
        }

       
        [HttpGet]
        public Syroup[] AllSyroups()
        {
            Program.NrRequests++;

            var folder = Directory.GetCurrentDirectory();
            var fileSyroup = FindFile(folder, search_type.syroup);
            SyroupMenu cm = new SyroupMenu();
            cm.loadfromfile(fileSyroup);
            cm.InOrder();
            return cm.SyroupMenuList.ToArray();
        }


        [HttpPost]
        public bool SaveOrder(Order order)
        {
            order.OrderStateModify(order_state.adding);

            var CoffeeAll = AllCofees();
            var SyroupAll = AllSyroups();

            bool OkAll = true;  //imi asum ca toate exista

            if (!order.coffees.Any())   //daca nu exista nici o cafea
                OkAll = false;

            for(int i = 0; i < order.coffees.Count; i++)    //pentru fiecare element din vectorul de cafele comandate verific daca exista in vectorul mare de cafele
            {
                var curent = order.coffees[i].coffee;

                if (CoffeeAll.Count(x=>x.name == curent.name) !=1 )   //numar cate cafele din lista mare de cafele sunt egale cu cafeaua mea (pe nume) si ar trebui sa fie 1
                    OkAll = false;

            }

            for (int i = 0; i < order.coffees.Count; i++)    //pentru fiecare element din vectorul de cafele comandate verific daca exista siropul in vectorul mare de siroape
            {
                var curent = order.coffees[i].syroup;
                if(curent != null)
                    if (SyroupAll.Count(x=>x.name == curent.name) != 1)    //daca una nu exista OkAll se face false si return false;
                        OkAll = false;
            }


            return OkAll;
        }
        


    }
}
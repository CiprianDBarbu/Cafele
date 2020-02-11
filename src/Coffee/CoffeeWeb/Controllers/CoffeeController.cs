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

    }
}
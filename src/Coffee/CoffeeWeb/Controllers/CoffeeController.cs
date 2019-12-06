using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CoffeeBL;
using Menu;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;


namespace CoffeeWeb.Controllers
{
    [Route("api/[controller]/{action}")]
    [ApiController]
    public class CoffeeController : ControllerBase
    {

        private string FindFileCoffee(string path)
        {
            //Directory.GetFiles(path, "ListCoffee.txt", SearchOption.AllDirectories);
            var files = Directory.GetFiles(path, "ListCoffee.txt");
            if (files.Length == 1)
            {
                return files[0];
            }

            var dirs = Directory.GetDirectories(path);
            for (int i = 0; i < dirs.Length; i++)
            {
               var file = FindFileCoffee(dirs[i]);
                if (file != null)
                    return file;
            }

            return null;

        }
        [HttpGet]
        public Coffee[] AllCofees()
        {
            var folder = Directory.GetCurrentDirectory();
            var fileCoffee = FindFileCoffee(folder);
            CoffeeMenu cm = new CoffeeMenu();
            cm.loadfromfile(fileCoffee);
            cm.InOrder();
            return cm.CoffeeMenuList.ToArray();
        }

        private string FindFileSyroup(string path)
        {
            //Directory.GetFiles(path, "ListSyroup.txt", SearchOption.AllDirectories);
            var files = Directory.GetFiles(path, "ListSyroup.txt");
            if (files.Length == 1)
            {
                return files[0];
            }

            var dirs = Directory.GetDirectories(path);
            for (int i = 0; i < dirs.Length; i++)
            {
                var file = FindFileSyroup(dirs[i]);
                if (file != null)
                    return file;
            }

            return null;

        }
        [HttpGet]
        public Syroup[] AllSyroups()
        {
            var folder = Directory.GetCurrentDirectory();
            var fileSyroup = FindFileSyroup(folder);
            SyroupMenu cm = new SyroupMenu();
            cm.loadfromfile(fileSyroup);
            cm.InOrder();
            return cm.SyroupMenuList.ToArray();
        }

    }
}
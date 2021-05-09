using Lab.Demo.Entities;
using Lab.Demo.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            TerritoriesLogic territoriesLogic = new TerritoriesLogic();

            Menu mainMenu = new Menu(territoriesLogic);
            
            mainMenu.MainMenu(territoriesLogic);
        }
    }
}

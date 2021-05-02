using Lab.Demo.EF.Entities;
using Lab.Demo.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.EF.UI
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

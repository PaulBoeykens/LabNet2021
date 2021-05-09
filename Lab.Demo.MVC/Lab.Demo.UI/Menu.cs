using Lab.Demo.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.Demo.Entities;

namespace Lab.Demo.UI
{
    public class Menu
    {
        private TerritoriesLogic territories;
        public Menu(TerritoriesLogic territories)
        {
            this.territories = territories;
        }
        public void Add(string id, string description, int idRegion)
        {
            territories.Add(new Territories
            {
                TerritoryID = id,
                TerritoryDescription = description,
                RegionID = idRegion
            });
        }
        public void Update(string idUpdate, string descriptionUpdate, int idRegionUpdate)
        {
            territories.Update(new Territories
            {
                TerritoryID = idUpdate,
                TerritoryDescription = descriptionUpdate,
                RegionID = idRegionUpdate
            });
        }

        public void Show()
        {
            foreach (var item in territories.GetAll())
            {
                Console.WriteLine($"{item.TerritoryID} - {item.TerritoryDescription} - {item.RegionID}");
            }
        }
        public void MainMenu(TerritoriesLogic territoriesLogic)
        {
            int optionMenu;
            do
            {
                try
                {

                    Show();
                    Console.WriteLine("Main Menu");
                    Console.WriteLine("\n" + "\n1- Add" + "\n2- Delete" + "\n3- Update" + "\n4- Exit\n");
                    Console.WriteLine("Choose an option");
                    int option = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    switch (option)
                    {
                        case 1:
                            Show();
                            try
                            {
                                Console.WriteLine("Enter the ID of the territory");
                                string idAdd = Console.ReadLine();
                                Console.WriteLine("Enter the description");
                                string description = Console.ReadLine();
                                Console.WriteLine("Enter the ID of the region");
                                int idRegion = Convert.ToInt32(Console.ReadLine());
                                Add(idAdd, description, idRegion);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Exception Catched!{ex.Message}");
                            }
                            Show();
                            break;
                        case 2:
                            Console.Clear();
                            Show();
                            Console.WriteLine("Enter the ID of the territory to delete");
                            string idDelete = Console.ReadLine();
                            try
                            {
                                territoriesLogic.Delete(idDelete);
                                Console.WriteLine("Territory deleted");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Exception Catched!{ex.Message}");
                            }
                            Show();
                            break;
                        case 3:
                            Console.Clear();
                            Show();
                            Console.WriteLine("Enter the ID of the territory to update");
                            string idUpdate = Console.ReadLine();
                            Console.WriteLine("Enter the description to update");
                            string descriptionUpdate = Console.ReadLine();
                            Console.WriteLine("Enter the ID of the region to update");
                            int idRegionUpdate = Convert.ToInt32(Console.ReadLine());
                            try
                            {
                                Update(idUpdate, descriptionUpdate, idRegionUpdate);
                                Console.WriteLine("Territory updated");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Exception Catched!{ex.Message}");
                            }
                            Show();
                            break;
                        case 4:
                            Console.WriteLine("Exit");
                            break;
                        default:
                            Console.WriteLine("Invalid Character");
                            break;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine($"1- One to continue\n4- Four to exit");
                optionMenu = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            } while (optionMenu != 4);
        }
    }
}

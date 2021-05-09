using Lab.Demo.Data;
using Lab.Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.Logic
{
    public class TerritoriesLogic : BaseLogic, IAMBLogic<Territories>
    {
        public List<Territories> GetAll()
        {
            return context.Territories.ToList();
        }
        public void Add(Territories newTerritories)
        {
            context.Territories.Add(newTerritories);
            context.SaveChanges();
        }
        public void Delete(string id)
        {
            var TerritoryToDelete = context.Territories.Find(id);

            context.Territories.Remove(TerritoryToDelete);
            context.SaveChanges();
        }
        public void Update(Territories territories)
        {
            var territoriesUpdate = context.Territories.Find(territories.TerritoryID);

            territoriesUpdate.TerritoryDescription = territories.TerritoryDescription;

            context.SaveChanges();
        }
        public Territories GetOne(string id)
        {
            return context.Territories.Find(id);
        }
    }
}

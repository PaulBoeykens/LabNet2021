using Lab.Demo.EF.Data;
using Lab.Demo.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.EF.Logic
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
    }
}

using Lab.Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.Logic
{
   public class RegionLogic : BaseLogic, IAMBLogic<Region>
    {
        public void Add(Region newTerritories)
        {
            throw new NotImplementedException();
        }
        public void Delete(string id)
        {
            throw new NotImplementedException();
        }
        public List<Region> GetAll()
        {
            return context.Region.ToList();
        }
        public void Update(Region territories)
        {
            throw new NotImplementedException();
        }
    }
}

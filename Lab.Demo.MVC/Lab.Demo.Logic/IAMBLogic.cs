using Lab.Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.Logic
{
    interface IAMBLogic<T>
    {
        List<T> GetAll();
        void Add(T newTerritories);
        void Delete(string id);
        void Update(T territories);
    }
}

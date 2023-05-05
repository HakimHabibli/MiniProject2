using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task05._04._23.Models.Common;

namespace Task05._04._23.Services.Implementations.Base
{
    public class BaseService<T> : IBaseInterface<T> where T : BaseEntity, new()
    {
        List<T> entities = new List<T>();
        public void Create(int id)
        {
            T entity = new();
            entity.Id = id;
            entities.Add(entity);
        }

        public void Delete(int id)
        {
            foreach (var item in entities)
            {
                if (item.Id == id)
                {
                    entities.Remove(item);
                }
            }
        }

        public T Get(int id)
        {
            T foundEntity = entities.Find(x => x.Id == id);
            return foundEntity;
        }
    }
}

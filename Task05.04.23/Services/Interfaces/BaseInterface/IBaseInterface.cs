using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05._04._23.Services.Interfaces.BaseInterface
{
    internal interface IBaseInterface<Tentity>
    {
        public void Create(int id);
        public void Delete(int id);
        public Tentity Get(int id);
    }
}

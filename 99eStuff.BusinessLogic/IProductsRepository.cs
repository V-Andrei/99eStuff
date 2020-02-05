using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _99eStuff.BusinessLogic
{
    public interface IProductsRepository
    {
        List<Products> GetAll();
    }
}

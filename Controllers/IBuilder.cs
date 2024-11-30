using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Controllers
{
    internal interface IBuilder<T> where T : class
    {
        string Add(T data);
        string Update(T data);
        string Delete(int id);
        DataTable Show(string searchText);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStock.DAL
{
    interface IOperation<T>
    {
        void Add(T item);
        List<T> Show();
        void Update(T item);
        void Delete(int id);
        //Getting an object filtering by expression
        T GetByFilter(Func<T, bool> expression = null);
    }
}

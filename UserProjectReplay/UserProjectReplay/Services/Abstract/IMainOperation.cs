using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserProjectReplay.Services.Abstract
{
    public interface IMainOperation<T>
    {
        //Crud - create, read, update, delete
        void Add(T model);
        List<T> GetAll();
        void Update(int id);
        void Delete(int id);    
    }
}

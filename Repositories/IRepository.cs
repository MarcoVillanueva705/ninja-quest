using System.Collections.Generic;

namespace NinjaQuest.Repositories
{
    //T means to be defined later
    public interface IRepository<T>
    {
       T Create(T t);
       T FindById(int id);
       List<T> Find();
       bool Delete(int id);
    }
}
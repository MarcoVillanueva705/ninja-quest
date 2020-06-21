namespace NinjaQuest.Repositories
{
    //T means to be defined later
    public interface IRepository<T>
    {
       T Create(T t);
    }
}
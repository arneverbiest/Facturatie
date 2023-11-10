namespace Facturatie.Interfaces
{
    public interface ICrud<T> where T : class
    {
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        T GetById(Guid id);
        List<T> GetAll();
    }
}

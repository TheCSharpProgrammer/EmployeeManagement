namespace EmployeeManagement.Interfaces
{
        public interface ICrud<T> where T : class
        {
            bool Add(T entity);
            bool Update(T entity);
            bool Delete(T entity);
            T GetById(int id);
            List<T> GetAll();
        }
}

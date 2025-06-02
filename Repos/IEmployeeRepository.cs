public interface IEmployeeRepository
{
    void Add(Employee employee);
    IEnumerable<Employee> GetAll(string nameFilter = null);
    bool ExistsByRFC(string rfc);
}
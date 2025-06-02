public class InMemoryEmployeeRepository : IEmployeeRepository
{
    private readonly List<Employee> _employees = new();

    public void Add(Employee employee) => _employees.Add(employee);

    public IEnumerable<Employee> GetAll(string nameFilter = null) =>
        _employees
            .Where(e => string.IsNullOrEmpty(nameFilter) || e.Name.Contains(nameFilter, StringComparison.OrdinalIgnoreCase))
            .OrderBy(e => e.BornDate);

    public bool ExistsByRFC(string rfc) => _employees.Any(e => e.RFC.Equals(rfc, StringComparison.OrdinalIgnoreCase));
}
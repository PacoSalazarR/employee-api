public class EmployeeService
{
    private readonly IEmployeeRepository _repository;

    public EmployeeService(IEmployeeRepository repository)
    {
        _repository = repository;
    }

    public bool TryAddEmployee(Employee employee, out string error)
    {
        if (!RfcValidator.IsValid(employee.RFC))
        {
            error = "Invalid RFC format.";
            return false;
        }
        if (_repository.ExistsByRFC(employee.RFC))
        {
            error = "An employee with this RFC already exists.";
            return false;
        }

        _repository.Add(employee);
        error = null;
        return true;
    }

    public IEnumerable<Employee> GetEmployees(string nameFilter = null) => _repository.GetAll(nameFilter);
}
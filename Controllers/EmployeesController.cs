using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class EmployeesController : ControllerBase
{
    private readonly EmployeeService _service;

    public EmployeesController(EmployeeService service)
    {
        _service = service;
    }

    [HttpPost]
    [Produces("application/json")]
    [ProducesResponseType(typeof(Employee), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult Create([FromBody] Employee employee)
    {
        if (!_service.TryAddEmployee(employee, out var error))
            return BadRequest(error);

        return Ok(employee);
    }

    [HttpGet]
    [Produces("application/json")]
    [ProducesResponseType(typeof(IEnumerable<Employee>), StatusCodes.Status200OK)]
    public IActionResult Get([FromQuery] string name)
    {
        var result = _service.GetEmployees(name);
        return Ok(result);
    }
}
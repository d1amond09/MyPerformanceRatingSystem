using System.ComponentModel;
using PerformanceRatingSystem.Domain.Entities;

namespace PerformanceRatingSystem.Application.Dtos;

public class DepartmentDto 
{
	public Guid DepartmentId { get; set; }
    [DisplayName("��������")]
    public string Name { get; set; }

    [DisplayName("����������")]
    public ICollection<EmployeeDto> Employees { get; set; }
}


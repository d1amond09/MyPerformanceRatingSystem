using System.ComponentModel;

namespace PerformanceRatingSystem.Application.Dtos;

public class EmployeeDto 
{
	public Guid EmployeeId { get; set; }
    [DisplayName("���")]
    public string FullName { get; set; }
    [DisplayName("���������")]
    public string Position { get; set; }
	public Guid DepartmentId { get; set; }
    [DisplayName("�����")]
    public DepartmentDto Department { get; set; }
}


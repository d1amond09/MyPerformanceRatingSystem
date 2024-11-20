using System.ComponentModel;

namespace PerformanceRatingSystem.Application.Dtos;

public class EmployeePerformanceIndicatorDto 
{
	public Guid IndicatorId { get; set; }
    [DisplayName("��������")]
    public string Name { get; set; }
	public Guid EmployeeId { get; set; }
    [DisplayName("���������")]
    public EmployeeDto Employee { get; set; }
}


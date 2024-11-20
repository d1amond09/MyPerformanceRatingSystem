using System.ComponentModel;

namespace PerformanceRatingSystem.Application.Dtos;

public class DepartmentPerformanceIndicatorDto 
{
	public Guid IndicatorId { get; set; }
    [DisplayName("��������")]
    public string Name { get; set; }
	public Guid DepartmentId { get; set; }
    [DisplayName("�����")]
    public DepartmentDto Department { get; set; }
}

